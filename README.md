# ARsomeChemistryMolecules

This is the repository housing the instructions and unity project for the ARsome Chemistry Molecules Project. This app allows students
to utilise the Vuforia Augmented Reality system through thier smartphone camera. By uploading line-angle structures of molecules as image targets,
Vuforia can recognize when a student draws specific molecules and display the corresponding 3D structure. THese 3D structures are made using .jmol and blender software for each image target. Included in this repository are some existing molecule targets in a unity package and the Unity file. The scene is called "TestTouchForCollision". The extended abstract for the purpose behind this paper and how this app can be used is found here: https://dl.acm.org/doi/10.1145/3447527.3474874 .

#Creating the 3D Molecules for use in Vuforia:
Go to http://jmol.sourceforge.net/
Download the jmol software
Watch an example video on the use of jmol https://www.youtube.com/watch?v=0mwkGDsSrnI
Open the jmol software and create the desired molecule (such as Acetaminophen)
Once this molecule is created, export the molecule as .vrml
You will need to open this exported 3d molecule file in blender
Download blender here: https://www.blender.org/download/
If new to blender, refer to this: https://www.blender.org/support/tutorials/
Open the .vrml file in blender, and edit the colors and shape of the rough model as you wish. The imported molecule will need to be rearranged somewhat post import
Join atoms and bonds in functional groups, making sure to exclude atoms that are not involved in any group. Those atoms will be joined at the end as a no-name object.
When you finish, depending on the size of the molecule, you should have no more than 4 functional groups and a group of uninvolved atoms. This will reduce the number of assets in the unity world, allowing the app to run faster.
Export the final molecule from blender as an .obj file for use in unity
Import this .obj file as an asset
Success, you can now attach the asset to an image target for use with vuforia

#Creating image targets for use in the project:
In its current state the project can recognize printed 2D-line angle structures, hand-drawn 2D line-angle structures, and the molecule name
For this to work you must upload your own image target to vuforia website to create an image target
For guidance on creating your own image targets and implementing Vuforia into Unity refer to this: https://www.youtube.com/watch?v=Z4bBMpa4xWo
For guidance with setting up your own vuforia process in your own project refer to: https://www.youtube.com/watch?v=9XikHnTiukk&list=PLX2vGYjWbI0Thl0pOCbKWrbbiw7RWiRG7&index=1
Once the image target is in unity, as described in the tutorials the 3D molecule object must be attached to the image target in scene.
If done correctly when run if the camera recognizes the image target correctly the 3D object should appear
