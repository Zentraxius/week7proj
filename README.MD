# Pierre's Bakery

#### An application to let a user check order cost, 7/17/20

#### By Cody Fritz

## Specification

1. Will allow user to receive a welcome message on running the application
2. Will allow user to order number of bread they want, and receive price based on that
3. Will allow user to order number of pastries they want and receive price based on that
4. Will allow user to order both pastries and bread and receive combined total
5. Will incorporate deals into the pricing, Bread is buy 2 get 1 free, pastries are 1 for $2 or 3 for $5
6. All will work together as planned
7. User can interface through the console/terminal

**Example**
|Behavior|Input|Output|
|---|---|---|
|Determine Price of Bread Order| 25 | 85 |
|Bread is priced at $5 for 1, buy 2  get 1 free. This translates to 3 for $10| Customer is ordering 25 loaves, 24 are priced at (24/3)*10 and the remaining is 5 each| Customer pays $80 for the 24 and $5 more for the extra, and thus pays $85|
|Determine Price of Pastry Order| 32 | 50 |
|Pastries are priced at $2 for 1 and $5 for 3| Customer ordered 32, 30 will be paid for as $5 for sets of 3 (30/3)*5, the remainder will be $2 each | Customer paid $54, which was (30/3)*5 + (2*2)|

## Installation

1.  Download a web browser, such as Apple Safari, Brave, Google Chrome, Microsoft Edge, Mozilla Firefox, or Yandex.
2.  Navigate to [repository]. ( https://github.com/Zentraxius/week7proj this one! )
3.  Click the green "Clone or download" button at the right of the screen.
4.  Select "Download ZIP."
5.  Use a file extractor or unzip program (such as PeaZip, Unzipper, WinZip, Zipware, or 7-ZIP) to extract the ZIP files onto your computer.
6.  Open the directory containing the extracted files.
7.  Open your computer's terminal and navigate to the directory bearing the name of the program and containing the top level subdirectories and files.
8.  Run dotnet restore to generate the backend files
    8a. (Note: Ensure you are in proper directory, for example if you are in Desktop/Bakery.Solution, you would need to either move into Desktop/Bakery.Solution/Project.Tests or run dotnet restore Project.Tests)
9.  Run dotnet test on Project.Tests to initiate the test, either by being in the Project.Tests directory, or running "dotnet test Project.Tests" without quotations from the Bakery.Solutions directory
10. Run dotnet run from Bakery.Solutions to run program as a whole.

## Known Bugs

When user orders an amount of bread &/ pastries where they are able to get an additional bread/pastry at the same price, no notice is given. This is not a bug, it is a feature.

## Support and contact details

For support please contact clanalia55@gmail.com

### Programming Languages & Libraries

C# / .netframework / VSC
Microsoft.net.SDK

### Operating Systems & Programs

- Git Bash
- Google Chrome(devtools)
- Microsoft Windows 10

### License

MIT

Copyright (c) 2020 **Cody Fritz**
