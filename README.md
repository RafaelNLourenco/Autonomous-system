# Geneva's group Champion of the 2021 edition 🏆
> College competition 🎓

![image](https://user-images.githubusercontent.com/52457167/151896814-91066a22-3235-4575-bfed-18b649fcda65.png)
### [Click](https://youtu.be/yoa8sVzKW3M) to see me against the A.S player 😅
---
## Features ###
+ Play as autonomous system
+ Play by yourself
+ Watch a match in real-time

## Getting started 
1. [Download](https://visualstudio.microsoft.com/downloads/) Visual Studio Community
2. In the Visual Studio Installer, choose the .NET desktop development
3. Clone this repositor

    ```
    git clone git@github.com:Rafasputnick/Sistema-autonomo.git 
    ```
5. Open the project

    ```
    <clone path>/Sistema-autonomo/cantStop/cantStop.sln
    ```
5. Run the project

## How Can't Stop board game works
There are 11 columns that range from 2 to 12. The objective is to be the first player to win 3 of those columns. When it is your turn, roll 4 dice at once and pair two pairs however you like. Add the total on each pair of dice, then you can advance in columns of the sums. Making pairs is a decision and the other one is stop or roll dice again. <br>
For more details check this quick guide [here](https://www.youtube.com/watch?v=VUGvOQatVDc)

## How A.S. make decisions
The game is based on math and statistic fundamentals and each decision calls for a different strategy:
+ Continue or stop - It uses some combinations, comparing the good cases and all possibilities
+ Make pairs of dice - It uses a couple of first degree polynomial functions comparing all union. Check the image bellow to have an idea
<p align="center">
    <img src="https://user-images.githubusercontent.com/52457167/152244911-0ef00854-974c-4c26-86d8-b508a04fefee.jpeg" alt="drawing" width="600"/>
</p>

## Changelog

### [v1.0.1]
- **Version Bump:** Fix all errors and update read me file

### [v1.0.0](https://github.com/Rafasputnick/Sistema-autonomo/releases/tag/1.0.0) First version (June 10th, 2021)
