#include <opencv2\opencv.hpp>

using namespace std;
using namespace cv;

void main()
{
	CascadeClassifier  kl_twarz, kl_oczy, kl_usta, kl_nos;

	kl_twarz.load("C:\\OpenCV248\\data\\haarcascades\\haarcascade_frontalface_default.xml");
	kl_oczy.load("C:\\OpenCV248\\data\\haarcascades\\haarcascade_eye_tree_eyeglasses.xml");
	kl_usta.load("C:\\OpenCV248\\data\\haarcascades\\haarcascade_mcs_mouth.xml");
	kl_nos.load("C:\\OpenCV248\\data\\haarcascades\\haarcascade_mcs_nose.xml");

	Mat obraz = imread("lena.jpg");
	vector<Rect> twarze, oczy, nosy, usta;

	kl_twarz.detectMultiScale(obraz, twarze);
	kl_oczy.detectMultiScale(obraz, oczy);
	kl_usta.detectMultiScale(obraz, usta);
	kl_nos.detectMultiScale(obraz, nosy);

	for (int i = 0; i < twarze.size(); i++)
		rectangle(obraz, twarze[i], CV_RGB(255, 0, 0), 2);
	for (int i = 0; i < oczy.size(); i++)
		ellipse(obraz, Point(oczy[i].x + oczy[i].width / 2, oczy[i].y + oczy[i].height / 2), Size(oczy[i].width / 2, oczy[i].height / 2), 360, 0, 360, CV_RGB(255, 255, 0), 2);
	for (int i = 0; i < usta.size(); i++)
		rectangle(obraz, usta[i], CV_RGB(0, 255, 0), 2);
	for (int i = 0; i < nosy.size(); i++)
		rectangle(obraz, nosy[i], CV_RGB(0, 0, 255), 2);


	imshow("Detekcja twarzy", obraz);
	waitKey();

}