# C-Search-and-Sort-Algorithms
My implementation of different search and sort algorithm. Still WIP

## Vergleichsbasiertes Sortieren:
| Sortieralgorithmus	| Best-Case |	Average-Case |	Worst-Case |	Stabil |	In-Place | Done |
|---------------------|-----------|--------------|-------------|---------|-----------|------|
| Bubblesort | O(n) |	O(n^2) |	O(n^2) |	Ja |	Ja | Ja |
| Heapsort |	O(n \cdot log(n)) |	O(n \cdot log(n)) |	O(n \cdot log(n)) |	Nein |	Ja | Nein |
| Insertionsort |	O(n) |	O(n^2) |	O(n^2) |	Ja |	Ja | Nein |
| Mergesort |	O(n \cdot log(n)) |	O(n \cdot log(n)) |	O(n \cdot log(n)) |	Ja |	Nein | Ja |
| Quicksort |	O(n \cdot log(n)) |	O(n \cdot log(n)) |	O(n^2) |	Nein |	Ja | Nein |
| Selectionsort |	O(n^2) |	O(n^2) |	O(n^2) |	Nein |	Ja | Nein |
| Shellsort	|	O(n \cdot log(n)^2) |	O(n^1,25) |	Nein |	Ja | Nein | Nein |

## Adressiertes Sortieren:
| Sortieralgorithmus |	Laufzeitkomplexität |	Speicherplatzkomplexität |	Stabil |	In-Place | Done |
|--------------------|----------------------|--------------------------|---------|-----------|------|
| Bucketsort |	O(n+k) |	O(n+k) |	Ja |	Nein | Nein |
| Countingsort |	O(n+k) |	O(n+k) |	Ja |	Nein | Nein |
| Radixsort	| O(n \cdot l) |	O(n) |	Ja |	Nein | Nein |
