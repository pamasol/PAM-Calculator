# Simple Calculator in C# .NET Windows Forms


## Setting up solution

1. Download and install Visual Studio Community Edition from [visualstudio.microsoft.com/downloads](https://visualstudio.microsoft.com/downloads/). 

2. Open Visual Studio and click **Create a new project**.

3. Choose **Windows Forms App (.NET Framework)** as shown in screenshot below and click **Next**.

![Create Winforms App](Documentation_Source/create_winforms_project.png)

4. Add **Project name** Calculator and update **Location** path accrording your needs.

5. As soon as the project has been created, check if **Toolbox** and **Solution Explorer** are visible as shown in the screenshot below in red. If not, add them via menu **View**.

![Create Winforms App](Documentation_Source/visual_studio_workspace.png)

6. Rename `Form1.cs` to `CalculatorForm.cs` in the **Solution Explorer** as shown in the screenshot above in green.

## Create visual part of the form

1. From the toolbox take 2x Label, 1x Button, 2x NumericUpDown and 1x ComboBox and place them on your form as shown in screenshot below.

![Winforms calculator](Documentation_Source/winforms_calculator.png)

2. Name them as follows in **Properties**:
    * `numericUpDownInput1` for input 1 that comes from the user
    * `numericUpDownInput2` for input 2 that comes from the user
    * `comboBoxOperation` for the operation dropdown
    * `buttonCalculate` for the calculation button
    * `labelEqual` for the = sign
    * `labelResult` for the area where the result will appear

We recommend switching the properties from the categorized view to alphabetical order. See screenshot below (first 2 icons in the Properties window), you'll find properties faster. Name is the name of the control, Text is what is written on the control. This logically implies that we can have multiple controls with the same text on a form, but they have to have different names.

![Edit items of comboBox](Documentation_Source/windows_forms_name.png)

**Label** is simply a text label. If we don't use a control in the code, we don't have to name it. If we do, we should set the `Name` property of it, then we'll be able to access this control using this name. `Name` is the name of the control, `Text` is what is written on the control. This logically implies that we can have multiple controls with the same text on a form, but they have to have different names. We name it `labelEqual` and `labelResult`.

**Button** is simply a button that calls a method (more precisely, an event) when clicked. In our case, we name this button `buttonCalculate` and we set its Text to `Calculate`. We'll assign the event to the button later.

**NumericUpDown** is a control for entering a value. By default, we can only enter an integer in it. We can change this behavior by setting the DecimalPlaces property, which specifies the number of decimal places. We'll set this value to `2` for both controls we put in our form. We also set their Minimum and Maximum properties. In our case, the minimum is `0`, the maximum `10000`. The advantage of entering numbers using this control is that the user isn't able to enter any nonsense value. We name the controls as `numericUpDownInput1` and `numericUpDownInput2`.

**ComboBox** is a drop-down list with several predefined items. Click right on the form and then **Edit items...**. Now you can put in the operation modes as shown in the screenshot below. We name it `comboBoxOperation`.

![Edit items of comboBox](Documentation_Source/properties_comboBox.png)

## Code the form

To be done
