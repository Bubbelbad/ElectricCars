
# ElectricCars

(This program is not entirely done yet, but it runs smooth)

The purpose of this application was to create an app with 5 design patterns and two sorting algorithms. I chose to make a fictive database that contains data for electric vehicles. The program displays a list of car proxies and the user is able to sort the proxies by brand or price, using two sorting algorithms. 

The user can then click on a specific proxy and it opens a window and retrieves the full car object with all the information about the chosen car. 
The user can also add new cars to the program using the Builder pattern. 


I chose the following patterns and algorithms for the project: 

- Singleton pattern (for database)
- Command pattern (to execute logic)
- Proxy pattern (to display car proxies)
- Builder pattern (for building car object)
- MVVM pattern (WPF structuring)
- Insertion sort & bubble sort (sorting algorithms)







## Lessons Learned

The MVVM pattern was completely new to me and in the beginning it was hard to understand how to structure the classes. Especially how to use bindings to trigger the desired functions in views from the viewmodels with parameters! The command pattern was one of the hardest nuts to crack in this regard and I'll definetely need more practise. 

For the car proxyList I used an ObservableColletion<T> which gave the benefit of updating the collection in real time (so smooth compared to for-loops and list for ensure it's up to date). 
I think I could've made the 'CanExecute' function private/protected in the RelayCommand, because non of the derived classes are modifying it and it would look cleaner. 

I'm very pleased with MVVM pattern and it has been SO MUCH FUN to program this! I love the structured map system, it makes it so easy to find what I'm looking for and gives a clear view of the responsibility of the classes. For future projects I'm eager to use UserControls and making the UI smooth while keeping simplicity in the structure, without cluttering the main tree.




## Screenshots

Screenshot main window: 

![Screen shot](https://github.com/Bubbelbad/ElectricCars/blob/master/Screenshot%202024-03-15%20215013.png)

Add car view: 

![Screen shot](https://github.com/Bubbelbad/ElectricCars/blob/master/Screenshot%202024-03-15%20215032.png)

