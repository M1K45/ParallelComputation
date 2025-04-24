# Badania szybkości wykonywania obliczeń w programowaniu równoległym

> Autor: Michał Kaszowski

## Wstęp
Stworzono aplikację okienkową służącą do mierzenia czasu mnożenia wygenerowanych losowo macierzy kwadratowych o zadanym wymiarze, przy pomocy zadanej ilości wątków.
Mnożenie macierzy zaimplementowano wykorzystując zarównao wątki nisko, jak i wysokopoziomowe.
(**Uwaga:** biblioteka `Paralell` automatycznie optymalizuje liczbę wykorzystanych wątków, przez co nie zawsze wykorzystywane jest tyle wątków, ile zadaje się w aplikacji)

## Wykorzystane technologie 
- .NET 8.0 (Windows Form App)
- Biblioteki `Paralell` i `Threads` do programowania wielowątkowego
- Biblioteka `MathNet` do tworzenia macierzy

## Najwazniejsze pliki aplikacji
- `Form1.cs`: Plik główny; zawiera logikę przeprowadzania pomiarów, wykonywania funkcji obliczających macierze, oraz opcjonalnie wizualizujące wynik obliczeń
- `Multiply.cs`: Implementacja mnożenia macierzy za pomocą wysokopoziomowych wątków (biblioteka `Paralell`)
- `MultiplyLowLewel.cs`: Implementacja mnożenia macierzy za pomocą niskopozoiomowych wątków (biblioteka `Threads`)

## Wyniki i Opis wykonanych testów

W celu porównania szybkości obliczeń w zależności od ilości wątków oraz implementacji wykonano testy: badano działanie programu dla liczby wątków od 1 do 8
na następujących rozmiarach macierzy: 400, 500, 600, 700, 800. Wyniki podane w tabeli poniżej są średnią 10 wykonanych pomiarów.

>Wszystkie wyniki podano w milisekundach

### Mnożenie macierzy 400x400

| Wątki | Wysokopoziomowo | Niskopoziomowo |
| ----- | --------------- | -------------- |
| 1     | 474             | 445.8          |
| 2     | 231.1           | 227.7          |
| 3     | 157.7           | 159.6          |
| 4     | 118.1           | 124.8          |
| 5     | 95.4            | 112.7          |
| 6     | 82.7            | 99.9           |
| 7     | 71.5            | 95.2           |
| 8     | 67.4            | 101.8          |


![image](https://github.com/user-attachments/assets/9639ee77-435d-4bae-b447-e6be48baba6a)


### Mnożenie macierzy 500x500

| Wątki | Wysokopoziomowo | Niskopoziomowo |
| ----- | --------------- | -------------- |
| 1     | 914.3           | 883.3          |
| 2     | 453.4           | 435.8          |
| 3     | 305.4           | 309            |
| 4     | 230.3           | 241.2          |
| 5     | 185             | 195.8          |
| 6     | 153.9           | 172.4          |
| 7     | 138.9           | 161.2          |
| 8     | 125.2           | 154.3          |


![image](https://github.com/user-attachments/assets/efc6a85f-44d3-473e-aeb4-8f4d3bbbdd6f)


### Mnożenie macierzy 600x600 

| Wątki | Wysokopoziomowo | Niskopoziomowo |
| ----- | --------------- | -------------- |
| 1     | 1634.5          | 1483.6         |
| 2     | 778.8           | 746.9          |
| 3     | 528.6           | 517            |
| 4     | 403.1           | 403.1          |
| 5     | 326.9           | 324.6          |
| 6     | 270.3           | 297.1          |
| 7     | 233.7           | 276.4          |
| 8     | 216.7           | 254.6          |

![image](https://github.com/user-attachments/assets/e95a2dbc-2857-4d2b-8b5a-de6f61cd98d4)


### Mnożenie macierzy 700x700

| Wątki | Wysokopoziomowo | Niskopoziomowo |
| ----- | --------------- | -------------- |
| 1     | 2431.7          | 2362           |
| 2     | 1251.2          | 1186           |
| 3     | 828.3           | 810.3          |
| 4     | 636.7           | 623.6          |
| 5     | 504.7           | 516            |
| 6     | 428.7           | 455.5          |
| 7     | 373.2           | 395.9          |
| 8     | 339.8           | 385.8          |

![image](https://github.com/user-attachments/assets/094a5b98-6e73-4550-8efc-3e11742744ac)

### Mnożenie macierzy 800x800

| Liczba wątków | Wysokopoziomowo | Niskopoziomowo |
| ------------- | --------------- | -------------- |
| 1             | 3757.5          | 3488           |
| 2             | 1852            | 1785.1         |
| 3             | 1237.8          | 1222.6         |
| 4             | 949.1           | 914.2          |
| 5             | 757.6           | 731            |
| 6             | 673.2           | 631.3          |
| 7             | 556.2           | 555.1          |
| 8             | 492.5           | 530.6          |

![image](https://github.com/user-attachments/assets/c033460a-5b8e-49aa-a491-26f3f090cb6b)

## Wnioski 
- Przy większej różnicy wątków (między 6 a 8) różnice w szybkości są dużo mniejsze niż przy mniejszej (między 1 a 3)
- Dla większej ilości wątkow zauważalna jest różnica na korzyść wątków klasy `Paralell~`, ze względu na optymalizację przydzielanych wątków (ostatecznie o ich ilości decyduje wynik algorytmu zawarty w ich implementacji)
