# csharp-Search-and-Sort-Algorithms
My implementation of different search and sort algorithm. Still WIP

## Vergleichsbasiertes Sortieren:
| Sortieralgorithmus	| Best-Case |	Average-Case |	Worst-Case |	Stabil |	In-Place | Done |
|---------------------|-----------|--------------|-------------|---------|-----------|------|
| Bubblesort | O(n) |	O(n^2) |	O(n^2) |	Ja |	Ja | Ja |
| Heapsort |	O(n * log(n)) |	O(n * log(n)) |	O(n * log(n)) |	Nein |	Ja | Ja |
| Insertionsort |	O(n) |	O(n^2) |	O(n^2) |	Ja |	Ja | Ja |
| Mergesort |	O(n * log(n)) |	O(n * log(n)) |	O(n * log(n)) |	Ja |	Nein | Ja |
| Quicksort |	O(n * log(n)) |	O(n * log(n)) |	O(n^2) |	Nein |	Ja | Ja |
| Selectionsort |	O(n^2) |	O(n^2) |	O(n^2) |	Nein |	Ja | Ja |
| Shellsort	|	O(n * log(n)^2) |	O(n^1,25) |	Nein |	Ja | Nein | Ja |

## Adressiertes Sortieren:
| Sortieralgorithmus |	Laufzeitkomplexität |	Speicherplatzkomplexität |	Stabil |	In-Place | Done |
|--------------------|----------------------|--------------------------|---------|-----------|------|
| Bucketsort |	O(n+k) |	O(n+k) |	Ja |	Nein | Nein |
| Countingsort |	O(n+k) |	O(n+k) |	Ja |	Nein | Nein |
| Radixsort	| O(n * l) |	O(n) |	Ja |	Nein | Nein |
