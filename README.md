# C-Search-and-Sort-Algorithms
My implementation of different search and sort algorithm. Still WIP

Sortieralgorithmus	Best-Case	Average-Case	Worst-Case	Stabil	In-Place Done
Bubblesort	O(n)	O(n^2)	O(n^2)	Ja	Ja
Heapsort	O(n \cdot log(n))	O(n \cdot log(n))	O(n \cdot log(n))	Nein	Ja
Insertionsort	O(n)	O(n^2)	O(n^2)	Ja	Ja
Mergesort	O(n \cdot log(n))	O(n \cdot log(n))	O(n \cdot log(n))	Ja	Nein
Quicksort	O(n \cdot log(n))	O(n \cdot log(n))	O(n^2)	Nein	Ja
Selectionsort	O(n^2)	O(n^2)	O(n^2)	Nein	Ja
Shellsort		O(n \cdot log(n)^2)	O(n^1,25)	Nein	Ja

Name	Laufzeitkomplexität	Speicherplatzkomplexität	Stabil	In-Place
Bucketsort	O(n+k)	O(n+k)	Ja	Nein
Countingsort	O(n+k)	O(n+k)	Ja	Nein
Radixsort	O(n \cdot l)	O(n)	Ja	Nein
