# Number Guessing Game (High or Low)

### Table of Contents

- [Overview](#overview)
- [Developed Using](#developed-using)
- [Features](#features)
- [How .NET is Used in Application](#how-net-is-used-in-application)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Game in Action](#game-in-action)
- [License](#license)

#### Overview

This C# console application is a simple Number Guessing Game. The player is prompted to set a range (minimum and maximum values) for the randomly generated number. Then, they attempt to guess the correct number within that range. The game provides feedback on whether the guessed number is too high or too low. After each round, the player has the option to play again. The game continues until the player decides to exit.

#### Developed Using

[![C#](https://img.shields.io/badge/language-C%23-blue.svg?style=for-the-badge)](https://docs.microsoft.com/en-us/dotnet/csharp/)

[![ASP.NET Framework](https://img.shields.io/badge/ASP.NET-Framework-blueviolet.svg?style=for-the-badge)](https://dotnet.microsoft.com/apps/aspnet)

#### Features:

- Customizable range for the generated number.
- Interactive feedback on each guess.
- Count of guesses required to win.
- Enjoy the challenge and have fun guessing the right number! 🎮

#### How .NET is Used in Application

- Developed using `C#`, a primary language supported by the .NET framework.
- Employing .NET Core's `dotnet` commands for building and running the application.
- Leveraging the `Visual Studio Community IDE`, providing the potential for future expansion into a web application.
- Making use of `standard .NET libraries`, including `System` namespaces. For instance:

  ###### User Input and Output (Console):

  - The application interacts with the user through the console. The usage of `Console.WriteLine` to display messages and `Console.ReadLine` to read user input are part of the System namespace in the .NET Framework.
    <br>
    > Console.WriteLine("What would you like your minimal value to be? ");
    > MinValue = Convert.ToInt32(Console.ReadLine());

  ###### Random Number Generation (System.Random):

  - The `Random` class from the System namespace to generate random numbers. This class is part of the .NET Framework and provides methods for generating random integers.
    <br>
    > Random random = new Random();
    > int NumberGenerated = random.Next(MinValue, MaxValue + 1);

  ###### Data Type Conversion:

  - The application uses `Convert.ToInt32` to convert user input (read as strings) into integer values. This conversion functionality is part of the .NET Framework.
    <br>

    > MinValue = Convert.ToInt32(Console.ReadLine());

  ###### String Manipulation:

  - The application uses string manipulation methods, such as `ToUpper`, to process user responses. These string operations are part of the .NET Framework
    <br>

    > Response = Console.ReadLine();
    > Response = Response.ToUpper();

#### Getting Started

To run the Number Enigma Game on your local machine, please follow the steps below:

1. Clone the repository to your local machine one of the following:
   HTTPS: <pre><code>git clone https://github.com/jvang0620/Number-Guessing-Game.git</pre></code>
   SSH: <pre><code>git clone git@github.com:jvang0620/Number-Guessing-Game.git</code></pre>

2. Navigate to the project directory and type `cd Number-Guessing-Game`.

3. Run the application by typing `dotnet run`.

4. The program will display in the output. :)

#### Usage

- Enter the minimal and maximal values when prompted.
- Start guessing the number within that range. Enter your guess when prompted.
- After each guess, you'll receive feedback on whether your guess is too high or too low.
- Keep guessing until you correctly identify the randomly generated number. The game will provide the total number of guesses you made.
- After each round, you have the option to play again. Enter "Y" to start a new game or "N" to exit.
- Have fun testing your guessing skills and enjoy the Number Guessing Game!
- Feel free to run the game multiple times, challenge yourself to guess the number with fewer attempts, and share the fun with friends.

#### Game in Action

![Screenshot of game #1](/images/image-1.PNG)

#### License

This project is licensed under the MIT License - see the [LICENSE.md](https://opensource.org/license/mit/) file for details.
