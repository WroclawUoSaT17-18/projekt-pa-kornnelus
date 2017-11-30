using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Personbaza
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        EntityState objState = EntityState.Unchanged;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using(IDbConnection db= new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    studentBindingSource.DataSource = db.Query<Student>("select *from Students", commandType: CommandType.Text);
                    pContainer.Enabled = true; 

                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = Image.FromFile(ofd.FileName);
                    Student obj = studentBindingSource.Current as Student;
                    if (obj != null)
                        obj.ImageUrl = ofd.FileName;


                }

            }
        }
        void ClearInput()
        {
            txtName.Text = null;
            txtLastName.Text = null;
            txtEmail.Text = null;
            txtAddress.Text = null;
            chkGender.Text = null;
            pic.Image = null;

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Student obj = studentBindingSource.Current as Student;
                if (obj != null)
                {
                    if (!string.IsNullOrEmpty(obj.ImageUrl))
                        pic.Image = Image.FromFile(obj.ImageUrl);
                }

            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objState = EntityState.Deleted;
            if (MetroFramework.MetroMessageBox.Show(this, "Czy chcesz usunąć ten rekord ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {

            
            try
            {
                    Student obj = studentBindingSource.Current as Student;
                    if(obj!=null)
                    {

                    
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    studentBindingSource.DataSource = db.Query<Student>("select *from Students", commandType: CommandType.Text);
                            int result = db.Execute("delete from students where StudentID = @StudentID", new { StudentID = obj.StudentID }, commandType: CommandType.Text);
                            if(result!=0)
                            { 
                            studentBindingSource.RemoveCurrent();
                            pContainer.Enabled = false;
                                pic.Image = null;
                                objState = EntityState.Unchanged;

                            }
                        }
                    }
                }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                Student obj = studentBindingSource.Current as Student;
                if (obj != null)
                {


                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        if (objState == EntityState.Added)
                        {
                            DynamicParameters p = new DynamicParameters();
                            p.Add("@StudentID", dbType: DbType.Int32, direction: ParameterDirection.Output);
                            p.AddDynamicParams(new { Imie = obj.Imie, Nazwisko = obj.Nazwisko, Email = obj.Email, Adres = obj.Adres, Plec = obj.Plec,ImageUrl=obj.ImageUrl});
                            db.Execute("sp_Students_Insert", p, commandType: CommandType.StoredProcedure);
                            obj.StudentID = p.Get<int>("@StudentID");
                        }
                        else if (objState==EntityState.Changed)
                        {
                            db.Execute("sp_Students_Update", new { StudentID = obj.StudentID, Email = obj.Email, Adres = obj.Adres, Plec = obj.Plec, ImageUrl = obj.ImageUrl }, commandType: CommandType.StoredProcedure);
                        }
                        metroGrid1.Refresh();
                        pContainer.Enabled = false;
                        objState = EntityState.Unchanged;
                        studentBindingSource.DataSource = db.Query<Student>("select *from Students", commandType: CommandType.Text);
                        int result = db.Execute("delete from students where StudentID = @StudentID", new { StudentID = obj.StudentID }, commandType: CommandType.Text);
                        if (result != 0)
                        {
                            studentBindingSource.RemoveCurrent();
                            pContainer.Enabled = false;
                            pic.Image = null;
                            objState = EntityState.Unchanged;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objState = EntityState.Added;
            pic.Image = null;
            pContainer.Enabled = true;
            studentBindingSource.Add(new Student());
            studentBindingSource.MoveLast();
            txtName.Focus();

        }
    }
} 

