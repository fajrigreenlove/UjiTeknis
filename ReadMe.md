#Muhammad Fajri
##Number 1
Remove if (application != null) unnecessary

##Number 2
return the GetApplicationInfo value

##Number 3
The LaptopData() method is a public method that displays the laptop information using the Console.WriteLine() method.

##Number 4
DisplayCount method is responsible for creating a new list, populating it, displaying the count, and returning the count. The main loop uses this count for its condition, avoiding the need to keep unnecessary references to objects.

##Number 5
To avoid the memory leak, you should ensure that you unsubscribe from the event before the EventSubscriber object goes out of scope. One way to do this is by implementing the IDisposable interface in the EventSubscriber class and unsubscribing from the event in the Dispose method.

##number 6
I've added a LimitNodes method which removes the oldest nodes when the total number of nodes exceeds a certain limit

##number 7 
I've added a MaxCacheSize property to the Cache class and a cacheLimit method to remove old items when the cache size exceeds the maximum
