# Guided Assignment 2
## Assignment
This assignment is the introduce the WPF controls
* Labels
* TextBoxes
* Buttons

You will do this by creating an application that does 3 seperate functions.

1. Create a small form that asks for the users first and last name. You then display their full name in a MessageBox. ( Revisit Guided Assignment 1 for a review on how to use a MessageBox )

2. Create a small form that asks the user for 2 numbers. The user can then choose to add or subtract the numbers. The full equation and result wil then be displayed.

3. Ask the user for a word. You will then ask them for a number and display the character located at that number 

You will also revisit previous concepts such as validating data, writing reusable code in methods, and parsing strings into numbers.
## Goal
Your goal is to become comfortable adding controls to your wpf forms, and working with lables, textboxs, and buttons in general. 

Also, you will be honing your C# skills. You will be using conditions, variables, methods, operations, outputs, and arrays. Review the Programming 1 materials in canvas to refresh on these concepts.

-------

### Steps
1. Start your project
    1. Create a new WPF Project
    2. Name it `GA_2_YourName`
    3. Add a label in the upper corner with your name
    4. Initialize and Push Your Repo onto GitHub
2. Message Box - Display Full Name
    1. Add the controls to your GUI
        * 3 Labels
        * 2 Text Boxes
        * 1 Button
    2. Name your controls
    3. Add a click event for your Button
    4. Create the code to display a the users full name
    5. Commit and Push
3. Label - Perform math and display the result in a label
    1. Add the controls to your GUI
        * 4 Labels
        * 2 TextBoxs
        * 2 Buttons
    2. Name your controls
    3. Add a click event for each button
    4. Write the code    
    5. Commit and Push
4. Text Box - Display the selected Character
    1. Add the controls
        * 3 Labels
        * 3 TextBoxes
        * 1 Button
    2. Name your controls
    3. Add a click even for your button
    4. Write the code
    5. Commit and Push
5. When everything is working. Submit your repo URL in Canvas


## Step By Step
### Part 1 - Start your project


1. Start your project
    1. Create a new WPF Project
    2. Name it `GA_2_YourName`
    3. In your .xaml, change the `<Grid>` tag to `<Canvas>`
    
    Replace
    ```html
    <Grid></Grid>
    ```

    with
    ```html
    <!-- <Grid></Grid> Removed -->
    <Canvas></Canvas>
    ```

    4. Initialize and Push Your Repo onto GitHub

    **Refer to Guided Assignment 1 if you need to refresh**

### Part 2 - Message Box - Display Full Name

**Requirements**

    * 4 Labels
    * 2 Text Boxes
    * 1 Button

![Example Result for Part 1](GA_2_Images\Part_2_Result.png)

1.  Add the controls to your GUI  
    In this step you will learn how to setup all your controls needed. Labels, Buttons, and TextBoxes. In the following parts, you will repeat these steps.

---

* **Label**  
    Labels are used to identify was related controls, such as being next to a text box, do. The user cannot interact with them.
    1. Adding a Label  
    In the toolbox ( Located to the left. You can use the hotkey **`ctrl + alt + x`** if you can't see it ), you'll see a list of WPF controls. Click and drag a Label control onto your view.

        ![Dropping a Label Onto our WPF Application](GA_2_Images\Label_Adding.gif)

    2. Change what the label says
        1. When you first place your label, it will say "Label". You can change this by changing the Label **`Content`** property, in the Xaml.

        ```html
        <Canvas>
            <Label Content="Label">
        </Canvas>
        ```

        2. Change the text in the double quotes to you message.

        **Required Labels :** 
        * Your Name - Guided Assignment 2
        * Display Your Full Name - Message Box
        * First Name
        * Last Name

        3. Place the label with YOUR NAME in the upper right hand corner of the app. The rest will depend on where you next controls are.

          ![Showing all 4 Labels](GA_2_Images\Adding_Labels.png)

---

* **TextBox**

    1. From the toolbar drag 2 TextBoxs onto your form
            ![Dropping a Label Onto our WPF Application](GA_2_Images\Adding_Textboxes.gif)

    2. In the .xaml code, delete the Property `Text="TextBox"` from each TextBox control. This will clear the text box.
    
    ```html
    <TextBox 
        Canvas.Left="32" 
        TextWrapping="Wrap" 
        Text="TextBox" // <-- Delete
        Canvas.Top="24" 
        Width="120"/>
    ```
    **Result**
    ```html
    <TextBox 
        Canvas.Left="32" 
        TextWrapping="Wrap" 
        Canvas.Top="24" 
        Width="120"/>
    ```

    3. Your Text Box should now be empty. Arrange your labels next to your text boxes so it's easy to indentify what a textbox is for.

        ![Dropping a Label Onto our WPF Application](GA_2_Images\Arranged_Text_Boxes.png)

---

* **Button**

    1. Drag a Button from your toolbox onto the Canvas.
        ![Drop a button from the toolbox onto your canvas](GA_2_Images\Adding_A_Button.gif)

    2. You will change the **`Content`** of the label to say **Display Full Name**.

    ```html
    <Button 
        Content="Display Full Name"
        />
    ```

**Result**
Your form should look similar to this.
![Example Result for Part 1](GA_2_Images\Part_2_Result.png)

---

#### 2. Name your Controls

In order for your **`.cs`** to recognize your controls, you need to name them.  
You will name your **2 TextBoxes and Button**. 

_You only need to name controls you plan to interact with in your code.  
 That's why we are not naming our labels on this step._

1. Click on the **`TextBox`** next to your First Name label.  
In your properties window ( Located in the bottom right. Hotkey **`F4`**), the very top field should say Name **No Name**.

    ![Dropping a Label Onto our WPF Application](GA_2_Images\Properties_Window.png)

2. Change the name of your **`2 TextBoxes and 1 Button`**. Names provided below.

**Requirements for names**
* txtFirstName
* txtLastName
* btnFullName

_**Naming Conventions: Your controls should start with consistent naming conventions  
TextBox : txt  
Button : btn  
Label : lbl  
They don't have to be these exact prefaces. But make them consistent**_

**XAML Result Example - Your code will have more location data, but it will have the same `Content` and `x:Name`**

```html 
 <Label Content="First Name"/>
 <TextBox x:Name="txtFirstName" />
 <Label Content="Last Name" />
 <TextBox x:Name="txtLastName" />
 <Button x:Name="btnFullName"   
    Content="Display Full Name" />
```
#### 3. Add a Click Event to your button
A click event is a method, written in your C#, that when properly attached, runs when a button is clicked. Each button can have it's own unique Click Event. To add an Event, just double click your button.

![Adding an event by double clicking a button](GA_2_Images\Double_Click_Event.gif)

**Result**
You should now see a method appear in your `.cs` code with 
`youButtonName_Click`

```csharp
    private void btnFullName_Click(object sender, RoutedEventArgs e)
    {
        
    } 
```
You can also the a `Click` property added to your button, with the same method name attached.

```html
    <Button 
        x:Name="btnFullName" 
        Content="Display Full Name" 
        Click="btnFullName_Click"/>
```
---

#### 4. Writing your C# code...

Work in progress

---
### Part 3
#### Step 1
#### Step 2
#### Step 3
#### Step 4

### Part 4
#### Step 1
#### Step 2
#### Step 3
#### Step 4



## Result
## Submission
