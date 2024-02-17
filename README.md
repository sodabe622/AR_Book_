 BookCover Project
----------------------------------------
Book Title: Software Engineering
--------------------------------------------
Author: Sodabe Bandali

Course: CS , Spring 2024

This project involves the development of an augmented reality (AR) version of a book cover, incorporating both augmented text and imagery. Utilizing the Vuforia Engine SDK within Unity, this effort resulted in the creation of AR adaptations for both the front and back covers of the "Software Engineering" book.

For the front cover, augmented reality technology overlays the book's title and author's name against a black backdrop, which conceals the original cover. 

The reverse side of the book offers a summary and other pertinent details, alongside a virtual button. This button allows users to switch between the book's information and a concise critique. Interaction with the button is enabled by touching the book's lower middle section. The project assets, including images of the original book covers, are archived in the Media directory.

Instructional Resources:
--------------------------------
-Developing image targets via the Vuforia Developer Portal.

-Creating a virtual button feature.

-Embedding augmented text onto an image target.

-Generating 3D animated character models with Adobe Mixamo.

File Storage:
----------------------------------------------
Several files, due to their size, are hosted using GitHub's Large File Storage (LFS), including:

Vuforia Engine SDK package

AR Book Cover assets

To access these files, GitHub LFS must be installed (git lfs install). Files are retrievable through cloning the repository.

Setup Instructions:
---------------------------------------------------------------
1. Clone the Repository: Start by cloning the project repository to your local machine. This will give you access to all the necessary files to run the project.

2. Register for an account and install the latest Unity Editor version, including the necessary modules based on your operating system. For instance, modules for Android and Windows build support were added for this project.

3. Open the Project in Unity, Launch Unity and navigate to the folder where you cloned the repository. Open the project to load it into Unity

4. (Optional) For the latest features, create a Vuforia Developer Account and download the latest Vuforia package, although the repository's version is also suitable for this project.


 Running the AR Book Cover Project:
--------------------------------------------------------

1. Running the AR Scene

Navigate to the Scene: Once the project is open in Unity, go to the Assets/Scenes directory. Here, you will find the scene named BookCover. Select this scene to work with it.
Run the Scene: With the scene selected, press the "Run" button to start the simulation. This will activate the AR functionality within the Unity editor.

2. Downloding ImageTarget

  Before starting, you should navigate to the "Assets" section in Unity and search for "ImageTarget." Within this section, you will find folders containing the front cover and back cover images of the book. Before running your project, make sure to download these images. After starting the application and activating the camera, you can use these specific images to view 3D objects and texts augmented onto them

3. Interacting with the AR Book Cover

-Front Page Interaction:

Hold the Front Page: Position the front page of the book in front of your web camera. Make sure the entire cover is visible to the camera.
View 3D Models: Once the front page is recognized, 3D models corresponding to the chair, desktop, laptop, and 3d assests, the book's title, and the author's name should appear overlaying the physical book cover.

-Back Page Interaction:

Hold the Back Page: Next, show the back page of the book to your web camera, similarly ensuring it's well positioned for recognition.
View General Information: The AR system will display general information about the book, including the author's name, the date of publication, and the total number of pages.
Accessing the Review:
For more details about the book, there are three buttons available. The first button, labeled "Pictures," allows you to view various images related to the book. The second button provides brief details about the book, such as the title, pages, and publisher. The third button, "More Details," offers a summary of the book's content. Each section includes a "Close" button, enabling you to return to the main menu, which displays the book's title and author's name.

Limitation:
--------------------------

The code has a problem because the virtual button doesn't work anymore. 


TargetImages:
----------------
![front](https://github.com/sodabe622/AR_Book_/assets/61977495/fef935bf-c6fc-45f3-8778-bb215f66bb29)
![back](https://github.com/sodabe622/AR_Book_/assets/61977495/e0aabecd-25b7-4f94-a44f-bb753a724973)
