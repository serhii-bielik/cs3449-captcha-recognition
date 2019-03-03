# Captcha Recognition
This project is the simple example of practical appliance of machine learning using C#. [Term project for Machine Learning course]

This application has several functions.
1.	Generating captcha datasets (via System.Drawing)
2.	Preprocessing. All images must be prepared before training NN. This steps include:
    -	Removing noise.
    -	Detecting individual characters.
    -	Cutting characters and normalizing them.
This done with [OpenCV](http://www.emgu.com/wiki/index.php/Main_Page) library
3.	Training [Fast Artificial Neural Network Library](http://leenissen.dk/fann/wp/)
4.	Testing and showing report:

![Captcha Recognition](screenshots/2019-03-03_17-49-19.png?raw=true "Captcha Recognition")
