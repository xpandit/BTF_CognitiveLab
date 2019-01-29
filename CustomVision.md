# Creating a custom vision
Lets go to [https://customvision.ai](https://customvision.ai)

Create a new project for bike classification
![create](screens/customvision_create.jpg)

## Let's train it first
We'll have 4 tags:
- Negative - we always need negatives
- bike
- perfect!
- vacuum cleaner

We have different sets of images, one for each, upload for each tag
![negative](screens/customvision_negative.jpg)


## after training, review performance

![performance](screens/customvision_performance.jpg)

### and get the prediction URL

![prediction](screens/customvision_prediction.jpg)

### Come back to the code and add the prediction url and keys to run.csx

![](screens/ex3_bot.jpg)

Or copy paste the code from [here](exercises/ex3/run.csx)
