// See https://aka.ms/new-console-template for more information
// tasks without built in methods
// Q:1
/*
List<int> numbers = new List<int>
{
15, -9, 0, 45, 87, 98, 23, 56
};
/* Q2
void PrintData(List<int> numbers)
{
    foreach (var number in numbers)
    {
        Console.WriteLine(number);
    }
} 

PrintData(numbers);
*/

//Q4 Method to check if an entry is found in the data
/*  bool IsItemFound(List<int> data, int entry)
  {
      foreach (var item in data)
      {
          if (item == entry)
          {
              return true;
          }
      }
      return false;
  }

  var numbers = new List<int> { 5, 2, 8, 1, 3 };

      // Check if an item is found
      int searchItem = 8;
      bool isFound = IsItemFound(numbers, searchItem);
      Console.WriteLine($"Item {searchItem} found: {isFound}");
 */


//Q5

/*
    // Method to check if an entry is found in the data
     bool IsItemFound(List<int> data, int entry)
    {
        foreach (var item in data)
        {
            if (item == entry)
            {
                return true;
            }
        }
        return false;
    }

    // Method to search data and print the index or a not found message
    void SearchData(List<int> data, int entry)
    {
        if (IsItemFound(data, entry))
        {
            int index = data.IndexOf(entry);
            Console.WriteLine($"Item {entry} found at index {index}.");
        }
        else
        {
            Console.WriteLine($"Item {entry} not found.");
        }
    }

   
        var numbers = new List<int> { 5, 2, 8, 1, 3 };

        // Search for an item
        int searchItem = 8;
        SearchData(numbers, searchItem);

        // Search for an item not in the list
        searchItem = 10;
        SearchData(numbers, searchItem);
    
*/

// Q6

/*
    // Method to reverse the data
    List<int> ReverseData(List<int> data)
    {
        List<int> reversedData = new List<int>();
        for (int i = data.Count - 1; i >= 0; i--)
        {
            reversedData.Add(data[i]);
        }
        return reversedData;
    }

   
        var numbers = new List<int> { 5, 2, 8, 1, 3 };

        // Reverse the data
        var reversedNumbers = ReverseData(numbers);
        Console.WriteLine("Reversed Data: " + string.Join(", ", reversedNumbers));
   */
//Q7
/*
    // Method to find the maximum value in the data
    int FindMax(List<int> data)
    {
        if (data.Count == 0)
        {
            throw new ArgumentException("The data list cannot be empty.");
        }

        int max = data[0];
        for (int i = 1; i < data.Count; i++)
        {
            if (data[i] > max)
            {
                max = data[i];
            }
        }
        return max;
    }

   
        var numbers = new List<int> { 5, 2, 8, 1, 3 };

        // Find the maximum value
        int maxNumber = FindMax(numbers);
        Console.WriteLine("Maximum Value: " + maxNumber);
   
*/
//Q8
/*
// Method to find the minimum value in the data


    // Method to find the minimum value in the data
     int FindMin(List<int> data)
    {
        if (data.Count == 0)
        {
            throw new ArgumentException("The data list cannot be empty.");
        }

        int min = data[0];
        for (int i = 1; i < data.Count; i++)
        {
            if (data[i] < min)
            {
                min = data[i];
            }
        }
        return min;
    }


        var numbers = new List<int> { 5, 2, 8, 1, 3 };

        // Find the minimum value
        int minNumber = FindMin(numbers);
Console.WriteLine("The minimum number in a list is " + minNumber);   
   */

//Q9
/*
    // Method to compute the average of the data
     double ComputeAverage(List<int> data)
    {
        if (data.Count == 0)
        {
            throw new ArgumentException("The data list cannot be empty.");
        }

        double sum = 0;
        foreach (var item in data)
        {
            sum += item;
        }
        return sum / data.Count;
    }

    
        var numbers = new List<int> { 5, 2, 8, 1, 3 };

        // Compute the average value
        double average = ComputeAverage(numbers);
        Console.WriteLine("Average Value: " + average);
    
*/

//Q10
/*
        int[] data = { 1, 2, 3, 1, 4, 1 };
        int entry = 1;
        int count = CountOccurrences(data, entry);
        Console.WriteLine(count);  // Output: 3
   

    int CountOccurrences(int[] data, int entry)
    {
        int count = 0;
        foreach (int item in data)
        {
            if (item == entry)
            {
                count++;
            }
        }
        return count;
    }
*/


// tasks using built in methods

// Q1
/*List<int> numbers = new List<int> 
{ 
   5, 1, 3, 2, 4
};


double median = FindMedian(numbers);
Console.WriteLine("Median: " + median);


double FindMedian(List<int> list)
{
   list.Sort(); // List ko sort karna
   int count = list.Count;

   if (count % 2 == 1)
   {
       // Agar count odd hai to middle element return karna
       return list[count / 2];
   }
   else
   {
       // Agar count even hai to do middle elements ka average return karna
       return (list[count / 2 - 1] + list[count / 2]) / 2.0;
   }
}     
*/
// Q2
/*    List<double> numbers = new List<double> { 10, 12, 23, 23, 16, 23, 21, 16 };
    double stdDev = ComputeStandardDeviation(numbers);
    Console.WriteLine("Standard Deviation: " + stdDev);


   double ComputeStandardDeviation(List<double> list)
{
    int count = list.Count;
    if (count <= 1) return 0; // Agar ek ya us se kam number hain, to standard deviation 0

    // Mean nikalna
    double mean = 0;
    foreach (double num in list)
    {
        mean += num;
    }
    mean /= count; // Total ka average

    // Sab numbers ka mean se difference square karna
    double variance = 0;
    foreach (double num in list)
    {
        double difference = num - mean;
        variance += difference * difference;
    }
    variance /= count; // Average difference

    // Standard deviation
    return Math.Sqrt(variance); // Square root le kar nikalna
}
*/
//Q3
/*
 * 
List<int> numbers = new List<int> { 1, 2, 3, 4, 2, 3, 5, 1 };
        List<int> uniqueValues = FindUniqueValues(numbers);
        Console.WriteLine("Unique Values: " + string.Join(", ", uniqueValues));
    

     List<int> FindUniqueValues(List<int> list)
    {
        HashSet<int> uniqueSet = new HashSet<int>(list); // HashSet duplicates ko automatically remove kar deta hai
        return new List<int>(uniqueSet); // HashSet ko List mein convert karke return karte hain
    }
*/


// Q4
/*
        List<int> list1 = new List<int> { 5, 2, 9 };
        List<int> list2 = new List<int> { 1, 7, 4 };
        List<int> sortedList = Sort(list1, list2);
        Console.WriteLine("Sorted List: " + string.Join(", ", sortedList));
                                     
*/
//Q5
/* List<int> Sort(List<int> list1, List<int> list2)
{
    // Do lists ko ek list mein merge karna
    List<int> mergedList = new List<int>(list1);
    mergedList.AddRange(list2);

    // Merged list ko sort karna
    mergedList.Sort();

    // Sorted list return karna
    return mergedList;
}
*/

//Q6
/* List<int> list3 = new List<int> { 3, 1, 4 };
 List<int> list4 = new List<int> { 2, 5, 6 };
 List<int> sortedMergedList = Merge(list3, list4);
 Console.WriteLine("Sorted Merged List: " + string.Join(", ", sortedMergedList));


List<int> Merge(List<int> list1, List<int> list2)
{
 // Do lists ko ek sath merge karna
 List<int> mergedList = new List<int>(list1);
 mergedList.AddRange(list2);

 // Merged list ko sort karna
 mergedList.Sort();

 // Sorted merged list return karna
 return mergedList;
}
*/

// 






