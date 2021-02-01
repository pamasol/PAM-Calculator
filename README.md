# PAM-Calculator programmed with Microsoft Visual Studio

[Pamasol Willi Mäder AG](https://www.pamasol.com/) has specialised in the development and production of solutions for aerosols and spray systems since 1965. 

Its Automatiker Lehrlinge (German for “mechatronic apprentices”) go through a 4-year apprenticeship. They get an on the job training by qualified Pamasol employees and go to college one or two days per week.

At Pamasol they work on customer projects as well as on internal training projects. PAM-Calcultator represents the internal object oriented programming project. It pursues the following goals:

* Learning an object oriented programming language
* Getting familiar with Visual Studio [IDE](https://en.wikipedia.org/wiki/Integrated_development_environment) and [.NET Framework](https://en.wikipedia.org/wiki/.NET_Framework)
* Becoming acquainted  to [C# programming language](https://en.wikipedia.org/wiki/C_Sharp_(programming_language))
* Building a [GUI](https://en.wikipedia.org/wiki/Graphical_user_interface) with [Windows Forms](https://en.wikipedia.org/wiki/Windows_Forms) and [WPF](https://en.wikipedia.org/wiki/Windows_Presentation_Foundation)
* Using [Git](https://en.wikipedia.org/wiki/Git) as software version control system and [GitHub](https://en.wikipedia.org/wiki/GitHub) for collaborative software development

## The Tutorial

> We start with the basics. Nevertheless it is recommended, doing [w3schools.com C# tutorial](https://www.w3schools.com/cs/) before continuing here.

The application you will create is a calculator with two input fields and one of the four fundamental arithmetic operatins that can be choosen. If someone tries to divide by zero, a fault message pops up:

![PAM Calculator Winforms Demo](PhilippBruhin/Calculator_Winforms/Documentation_Source/pam-calculator_winforms_demo.gif)

You will build the same calculator twice. In a first step you will work with the WinForms class library, the second calculator is built with WPF. The single most important difference between WinForms and WPF is the fact that while WinForms is simply a layer on top of the standard Windows controls (e.g. a TextBox), WPF is built from scratch and doesn't rely on standard Windows controls in almost all situations. This might seem like a subtle difference, but it really isn't, which you will definitely notice while doing follwing tutorials:

1. [Calculator Tutorial Winforms](https://github.com/pamasol/PAM-Calculator/tree/master/PhilippBruhin/Calculator_Winforms/readme.md)

2. [Calculator Tutorial WPF](https://github.com/pamasol/PAM-Calculator/tree/master/PhilippBruhin/Calculator_WPF/readme.md)

Have fun :rocket: