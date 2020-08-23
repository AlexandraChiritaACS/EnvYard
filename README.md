# EnvYard
(The Unity Project is in the unity_branch)
Inspiration
EnvYard is from environmental yard, even if it's a funny word combination.

Only last year over 3 Mha were lost in Asia due to deforestation for agricultural purposes. In Africa is even more sensitive because many endangered species of animals lost their habitats and have to be put in shelters. But the problem is that the population need a source of food and it seems like a big compromise regarding environmental ethics.

Some papers were published which describe the way multilevel greenhouses would work. They would save a lot of space and help with the plantation separation. There are some plantations of this king in Asia, but they don't meet the expectation regarding production. A way in which the production needs might be meet would be to create a sustainable, autonomous system to maintain the plants from the greenhouse. It is more efficient than human work.

What it does
The EnyYard is a simulation of a system which provides the services for optimal plantation maintenance. The greenhouse would have the following features: 1. Solar Cells to provide power for the system. The simulation calculates the power considering the fact that a part of the greenhouse is covered with solar panels. 2. Mirrors for light uniform distribution. 3. Smart irrigation system. 4. Drone for checking the levels. We also provide a platform for statistics and predictions for the farmers to see their plantations' status.

How we built it
We used Unity and EchoAR for the simulation. Also, the Bubble.io was used for the interface, database and Google AutoML for predictions. We intent to add the Vision feature in the website and in the Unity project.

Challenges we ran into
First of all, we had a problem with deploying the app to web, because of the asynchronous calls made for the EchoAR models. Some optimizations But the app is available on desktop and is portable: it can be deployed on Web, Mobile and even VR/AR apps. Also, integration of Bubble and Google APIs like AutoML and Vision was a real challenge, due to the fact that the APIs changed a lot in the last years.

Accomplishments that we're proud of
What we learned
It think this was our first app using Unity. We were really excited about it, especially because is an old and important idea. Also, we had the chance to learn Bubble and more about Google APIs.

What's next for EnvYard
This seems to be a long time project, regarding the technologies which will be used, the hardware design, the funds, etc. First of all, the platform should be integrated to a real greenhouse like one in the simulation. In order to see the plants from it we would use a 360 camera with will export the image in the VR/AR simulation. Also, we would like to add more features regarding the organisation and the automatized maintenance, probably using APIs from Google Cloud and our own code.

Built With
automl
bubble.io
dialogflow
echoar
unity
vision
