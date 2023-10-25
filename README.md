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

![Example Result for Part 1](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Part_2_Result.png)

1.  Add the controls to your GUI  
    In this step you will learn how to setup all your controls needed. Labels, Buttons, and TextBoxes. In the following parts, you will repeat these steps.

---

* **Label**  
    Labels are used to identify was related controls, such as being next to a text box, do. The user cannot interact with them.
    1. Adding a Label  
    In the toolbox ( Located to the left. You can use the hotkey **`ctrl + alt + x`** if you can't see it ), you'll see a list of WPF controls. Click and drag a Label control onto your view.

        ![Dropping a Label Onto our WPF Application](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Label_Adding.gif)

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

          ![Showing all 4 Labels](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Adding_Labels.png)

---

* **TextBox**

    1. From the toolbar drag 2 TextBoxs onto your form
            ![Dropping a Label Onto our WPF Application](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Adding_Textboxes.gif)

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

        ![Dropping a Label Onto our WPF Application](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Arranged_Text_Boxes.png)

---

* **Button**

    1. Drag a Button from your toolbox onto the Canvas.
        ![Drop a button from the toolbox onto your canvas](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Adding_A_Button.gif)

    2. You will change the **`Content`** of the label to say **Display Full Name**.

    ```html
    <Button 
        Content="Display Full Name"
        />
    ```

**Result**
Your form should look similar to this.
![Example Result for Part 1](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Part_2_Result.png)

---

#### 2. Name your Controls

In order for your **`.cs`** to recognize your controls, you need to name them.  
You will name your **2 TextBoxes and Button**. 

_You only need to name controls you plan to interact with in your code.  
 That's why we are not naming our labels on this step._

1. Click on the **`TextBox`** next to your First Name label.  
In your properties window ( Located in the bottom right. Hotkey **`F4`**), the very top field should say Name **No Name**.

    ![Dropping a Label Onto our WPF Application](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Properties_Window.png)

2. Change the name of your **`2 TextBoxes and 1 Button`**. Names provided below.

**Requirements for names**
* txtFirstName
* txtLastName
* btnFullName

> _**Naming Conventions: Your controls should start with consistent naming conventions  
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

![Adding an event by double clicking a button](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Double_Click_Event.gif)

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

1. Message Box in a Button

    1. Since this the our first button, lets test that it works.  
    In your code, Hotkey `F7`, you will find you btnFullName_Click Event.

    ```csharp
    private void btnFullName_Click(object sender, RoutedEventArgs e)
    {

    } // btnFullName_Click
    ```
    
    2. This method runs everytime you click your button. To test it out we are going to put a `MessageBox.Show()` inside our button and run our code. If it works we should see a pop up appear when we click the button.

    ```csharp
       private void btnFullName_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("This event works");
    } // btnFullName_Click
    ```

**Result**

_Well be greating the rest of the GUI in the following problems_
![Testing our Click Event on Display Full Name Button](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Test_Button_FullName.gif)

---

2. Displaying the Users Name
    Now that we know our button is working, it's time to grab the text from our two name text boxes.  

    Inside of our Click event we are going to grab the text from `txtFirstName` and save it in a variable.
    
    _**To grab Text from a textbox, uses the .Text property!**_

    1. Inside of our Click Event declare a string variable called `string firstName` and assign it the value from the `txtFirstName` text box by using the `.Text` property.

    2. Using our `MessageBox.Show()` pass in `firstName` and run our code.  
    Test it by typing something in the first name box and hitting our button. That message should appear in the message box!
    
    ```csharp
    private void btnFullName_Click(object sender, RoutedEventArgs e)
    {
        // Grab the Text from the txtFirstNameBox.Text
        // Save it to a string variable
        string firstName = txtFirstName.Text;

        // Display the string variable in the message box
        MessageBox.Show(firstName);
    } // btnFullName_Click
    ```

    ![Testing we are getting the Text from our First Name Box](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Demo_FirstName.gif)

---

3. Finish the code for the Full Name

    1. Now that you know how to pull the text from one box, do the same thing for the second box.

    2. After that create a third string variable called `string fullName` and use it to hold the `firstName` and `lastName` variables, concatenated together.

   > _Refresher : Concatenate means to combine two objects together. In Programming it means we are combining strings together._
    
    ```csharp
    string greeting = "Good Morning";
    string group = "Everyone!";
    string concatenate = greeting + ", " + group;
    // Result
    Console.WriteLine(concatenate); 
    Good Morning, Everyone!
    ```

    3. Once completed you should see the full name appear when the button is clicked.

**Result**
![Your final result should display the text from both text boxes in your message box.](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Step_1_Result.gif)


```csharp
private void btnFullName_Click(object sender, RoutedEventArgs e)
{
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;

        // Declare a third string, full name
        // Concatenate ( combine ) the first and last name into one long string
        string fullName = $"{firstName} {lastName}";

        // Display full name on button click
        MessageBox.Show(fullName);

} // btnFullName_Click
```

#### 4. Save your project, Commit, and Push

1. Get into the pattern of constantly saving your project as you work on it. Then commiting and push your code everytime you make large changes. No one wants to redo work if our project crashes.

---
### Part 3 - Label - Perform math and display the result in a label

#### 1. - Setup your GUI - Controls, Names, and Click Events
1. Following the same process as Part 2, setup your GUI. You will add 
>    * Labels - 4
>        1. Content: _Perform a Calculation - Label_
>        2. Content: _Number 1_
>        3. Content: _Number 2_
>        4. Name: `lblSign` - Content: _Sign_  
>            * **THIS NEEDS TO BE NAMED**, we will being changing it with code  
>            Name: `lblEquation`
>    * TextBoxes - 2
>        1. Name: `txtNumber1`
>        2. Name: `txtNumber2`
>    * Buttons - 2
>        1. Name: `btnAdd` - Content : _Add_
>            * Double click after naming to attach a Click Event
>        2. Name: `btnSubtract` - Content : _Subtract_
>            * Double click after naming to attach a Click Event

![An example of how your GUI could look](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Part_3_GUI.png)

_MainWindow.xaml_
```html
        <Label Content="Perform a Calculation - Label" />
        <Label Content="Number 1" />
        <TextBox x:Name="txtNumber1" />
        <Label Content="Number 2"/>
        <TextBox x:Name="txtNumber2" />
        <Button 
            x:Name="btnSubtract"   
            Content="Subtract"  
            Click="btnSubtract_Click" />
        <Button 
            x:Name="btnAdd" 
            Content="Add" 
            Click="btnAdd_Click" />
        <!-- Remember to Name this Label -->
        <Label x:Name="lblEquation" Content="Sign" />
```

_MainWindow.xaml.cs_
```csharp
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            
        }
```

#### 2. - Writing Your CSharp Code
1. This process will start the same as Part 2. 
    1. Create variables to hold the values from our text Boxes.
    2. Test to make sure they work, but this time with our Label.

    _Change Label Content in Code_

    > The `labelName.Content` property allows you to get or set the value.
    >
    > Set : `labelName.Content = "New Message":`  
    > Get: `string value = labelName.Content;`    

    ```csharp
    private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
        // We can change the .Content property of a named label
        // This lets us what changes while the app is running
            lblEquation.Content = "New Message";
        }
    ```
    ![Demonstrating Changing a label in code](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Change_Label_Example.gif)
    
    3. Putting everything together ( concatenating and display the result to your label ) output a string that looks like `5 + 7 = 57`. If number1 equaled 5 and number2 equaled.

    ```csharp
     private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
        
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            // For readability I decided to add a sign and equal variable
            string sign = "+";
            string equalSign = "=";
            string result = number1 + number2;
            // I use a string literal to make it easier to format my equation with lots of variables
            string equation = $"{number1} {sign} {number2} {equalSign} {result}";

            // Displaying the equation string
            lblEquation.Content = equation;
        }
    ```

 ![Adding our strings](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Testing_Add_W_Strings.gif)

#### 3. - Parsing Into Numbers to Perform Math
You probably noticed a problem here. We didn't do math, we concatenated our strings 5 + 7 to create 57. In order to do math we need to tell the computer to recognize 5 and 7 as numbers. To do that we are going to Parse them.

> Using the `type.Parse(string)` method, we try to convert a string argument into a different type. If successful we save the converted type. If unsuccessful the application will crash unless properly dealt with. See GitHub repo for my approach to preventing a crash.

_Parsing Strings into different Types_
```csharp
    string numberString = 7; // Computer sees a number
    int number = int.Parse(numberString); // Tries to convert to a whole number ( int )

    string addingStrimgs = numberString + numberString; // 77
    int addingNumbers = number + number; // Result : 14
```

1. Going back to our code let's change a few things.

_Original_
```csharp
     private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
        
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            // For readability I decided to add a sign and equal variable
            string sign = "+";
            string equalSign = "=";
            string result = number1 + number2;
            // I use a string literal to make it easier to format my equation with lots of variables
            string equation = $"{number1} {sign} {number2} {equalSign} {result}";

            // Displaying the equation string
            lblEquation.Content = equation;
        }
```
2. Create 2 new variables under our first 2 string variables.
    1. `int num1;`
    2. `int num2;`

3. Then parse our string number1 and string number2 using `int.Parse`. Depending on what you are trying to parse you can also do doubles, bools, etc...
    1. `int num1 = int.Parse(number1);`
    2. `int num2 = int.Parse(number2);`

4. Finally, for our `result` variable, change the type to `int` and replace `number1 + number2` with `num1 + num2`. The should result in you performing math. Our string equation should continue to work properly.  
    Replace: `string result = number1 + number2`;
    New: `int result = num1 + num2`;

_New_
```csharp
     private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
        
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            // Parsing my numbers
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            string sign = "+";
            string equalSign = "=";
            // Doing math with our new int
            int result = num1 + num2;
     
            string equation = $"{number1} {sign} {number2} {equalSign} {result}";

            // Displaying the equation string
            lblEquation.Content = equation;
        }
```
![Adding our Numbers Together](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Math_Addition.gif)


#### 4. Subtraction - The Easy Way ( Copy and Paste )
1. Now with our addition button done lets think like programmers and quickly finish the Subtraction button.

    Copy all the code INSIDE of your Addition Button. ( Remember `ctrl + c` to copy)
```csharp
     private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
        // COPY FROM HERE ------------------
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            string sign = "+";
            string equalSign = "=";
            int result = num1 + num2;
     
            string equation = $"{number1} {sign} {number2} {equalSign} {result}";

            lblEquation.Content = equation;
        // TO HERE -------------------------------
        }
```

and paste that code inside of your Subtract Click Event.


```csharp
     private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            string sign = "+";
            string equalSign = "=";
            int result = num1 + num2;
     
            string equation = $"{number1} {sign} {number2} {equalSign} {result}";

            lblEquation.Content = equation;
        }
```

2. And since the only real difference between our Add and Subtract methods are switching `+` to `-` then we just change   
`sign = "-"`  
`result = num1 - num2;`.

```csharp
     private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            string number1 = txtNumber1.Text;
            string number2 = txtNumber2.Text;
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            string sign = "-"; // Changes + to -
            string equalSign = "=";
            int result = num1 - num2; // Changed + to -
     
            string equation = $"{number1} {sign} {number2} {equalSign} {result}";

            lblEquation.Content = equation;
        }
```

![Subtracting Numbers](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Math_Subtraction.gif)

#### 5. Save, Commit, Push
Now done with Part 3. Save, Commit, and Push your project.

--------------------------

### Part 4 - Text Box - Display the selected Character
#### 1. Add the controls, names, and Click Event

> * Labels - 3
>    1. Content: *Display a Letter from a Word - Text Box*
>    2. Content: *Enter a word*
>    3. Name: `lblNumberOfLetters` - Content: *Enter a number*
> * TextBox - 2
>    1. Name: `txtWord`
>       * ***Double Click This TextBox***  
>           This will create a _TextChange Event. This is an event that is called everytime the text inside of this text box is changed
>    2. Name: `txtCharIndex`
>    3. Name: `txtDisplayLetter`
>* Button - 1
>    1. Name: `btnDisplayLetter` - Content: *Display Letter*

![Example of a possible Gui for Part 4](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Part_4_GUI.png)

*MainWindow.xaml*
```html
  <Label Content="Display a Letter from a Word - Textbox" />
  <Label Content="Enter a Word" />
  <Label 
    x:Name="lblNumberOfLetters" 
    Content="Enter a number"  />
  <TextBox 
    x:Name="txtWord" 
    TextChanged="txtWord_TextChanged" />
  <TextBox x:Name="txtCharIndex" />
  <Button 
    x:Name="btnDisplayLetter" 
    Content="Display Letter" 
    Click="btnDisplayLetter_Click"/>
  <TextBox x:Name="txtDispayLetter" />

```
*MainWindow.xaml.cs*
```csharp

    private void txtWord_TextChanged(object sender, TextChangedEventArgs e)
    {

    } // txtWord_TextChanged

    private void btnDisplayLetter_Click(object sender, RoutedEventArgs e)
    {

    } // btnDisplayLetter_Click

```

#### 2. Write the code

> For this part we ask the user for a word and a number. Using our knowledge of `arrays` we take the users number, parse it, and use it as an index to display the selected character.

1. Let's start with the `txtWord_TextChanged` event. We're going to do something cool. We're gonna write some code so that when the user types their word in, it'll display the range of numbers the user can choose from in our `lblNumberOfLetters`.

```csharp
private void txtWord_TextChanged(object sender, TextChangedEventArgs e)
{
    string usersWord = txtWord.Text; // Getting users word
    int stringLength = usersWord.Length; // Getting how many characters are in the word
    int lastIndex = stringLength - 1; // Getting the last index of the word
    string formatedString = $"Enter a number between 0 and {lastIndex}"; // Displaying the range of 0 to the last index

    // Displaying it to our label
    lblNumberOfLetters.Content = formatedString;
}
```

> Whats happening here.
> 1. First we are getting the users word.
> 2. C# looks at strings as an `array of characters`.  
> Since all arrays have a `.Length` property that tells us how many elements there are. We are using `usersWord.Length` to tell us how many letter there are.  
>  Example :   
>  William has a .Length of 7  
>  Sandy has a .Length of 5
> 3. The length gives us how many characters there are in an array. But the last index is **ALWAYS** `.Length - 1`. So the last index of William would be 6  
> W I L L I A M  
> 0 1 2 3 4 5 6
> 4. We've now gone ahead and formatted a string that will be updated after every keystroke.   
> `$"Enter a number between 0 and {lastIndex}";`  
> Which will tell the user the range of numbers they can choose from without breaking our code.   
> ***Choosing a larger or smaller number will result in an index out of bounds error***
> 5. Lastly, we assign out string as a value to our `lblNumberOfLetters.Content`. All of this will show the user a real time update of numbers to select from.

![Demonstrating Real Time Number Range Update](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Number_Update.gif)

2. And with that done, our final code is simple.

    In our `btnDisplayLetter_Click` Event  
    1. Create a variable to hold the text from `txtWord`.
    2. Create a variable ( or variables ) to get the txt from `txtCharIndex`. And since we plan to use it for an `INDEX`, you need to parse it as an `int`.
    > An Index is always an integer ( a whole number )
    3. Then you can create a `char` variable ( a single character ) with the following code.
    
    `char selectedChar = usersWord[usersNumber]`
    > Replace usersWord with the variable you made to hold the users entered word. And replace usersNumber with your variable holding the int. Don't forget the brackets! **[ ]**

    4. Lastly, assign the character to your `txtDisplayLetter.Text`. Make sure to `.ToString()` your selected char.   
    `txtDisplayLetter.Text = selectedChar.ToString();`
    > Instead of .Content, you change the .Text for textboxes.

***MainWindow.xaml.cs (Your variable names might be different. That's OK)***
```csharp
  private void btnDisplayLetter_Click(object sender, RoutedEventArgs e)
  {
      string userWord = txtWord.Text;
      // Grabbing the word and parsing in one line
      int usersNumber = int.Parse(txtCharIndex.Text);
      char selectedChar = userWord[usersNumber];

      txtDisplayLetter.Text = selectedChar.ToString();
  } // btnDisplayLetter_Click
```

And that's it! If everythings done correctly, when you enter a word, a valid number, and press the button it should display the selected letter.

![Demonstrating Real Time Number Range Update](https://raw.githubusercontent.com/WCramRTC/GA_Images/main/GA_2_Images/Part_4_Result.gif)


#### 3. Save, Commit, and Push
Your done! Save, commit your project, and push it online.

## Result
You should now have all 3 Parts on a single application. And working. Submit for points and feedback!


## Submission
After your final commit and push, submit your repo URL to the textbox in the assignment on Canvas.
