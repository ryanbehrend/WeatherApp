# FinalProject

Final Project for Object Oriented Design - Spring 2025 - Dakota State University

To use this simply run the program and enter either a city name or a zip code.

City names can be entered as follows:
- Tampa
- Tampa, FL
Using the second option will ensure you are looking at the correct city

Zip Codes can be entered as follows:
- 33592

Once you have entered a name or zip code click search. The data will appear on the screen. By default it will be in the imperial system but you can change to whichever you would like using the dropdown menu on the left.

Additionally, you can add and remove favorites. After searching for a city or zipcode, click the "Add to Favorites" button and it will appear in the list of favorites. You can remove the current location by clicking the "Remove from Favorites" button. These favorites will be saved in a json file so you can view them again when the program is run again.

The refresh button may not appear to do anything, but the console logs show it retreives updated weather data fro the current location.

Finally, you can view a 5-day forecast by clicking the "View 5-Day Forecast" button. This will open another window with all the same information as on the main page, but will show the information at 3 hour increments for the next 5 days.

Once this project is done for my class I will remove my API key from the repository so the program won't work correctly. To make it work you simply make an account at https://openweathermap.org and get your own free API key. Copy and paste it into the appsettings.json file and the program should work again.
