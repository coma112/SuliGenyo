# Optimalizáció Dokumentum

## Táblázat magyarázat

- Runtime: Futási idő, hogy az adott metódus mennyi idő alatt futott le.
- Memory Allocation: A memóriaterület lefoglalása az adatok számára.
- Gen0: A rövid életű objektumok gyors memória-felszabadítási folyamata. (Garbage Collection)

# Benchmark Táblázat & Eredmények

Amelyik nincsen ott az elhanyagolhatónak tekinthető. 

| Feladat | Megközelítés | Runtime | Memory Allocation | Gen0 | Kép |
|---------|-------------|-------------|------------------|------------------|---|
| 1. feladat | LINQ | 9,45 μs | 12,93 KB | 8,40 | ![](https://i.imgur.com/8el0Sgg.png)
| | StringBuilder ✅ | 7,32 μs | 7,66 KB | 4,98 |
| 2. feladat | LINQ | 2,19 μs | 1214 B | 0,77 | ![](https://i.imgur.com/z4liOmx.png)
| | For loop ✅ | 1,55 μs | 437 B | 0,27 |
| 3. feladat | LINQ ✅ | 506 ns | 244 B | 0,15 | ![](https://i.imgur.com/At2Lquq.png)
| 4. feladat (982451653) | LINQ  | 129,3 μs | 84 B | - | ![](https://i.imgur.com/93JU2Dq.png)
| | For loop ✅ | 17,19 μs | - | - |
| 5. feladat | Hagyományos ✅ | 504 ns | 200 B | 0,12 | Elfelejtettem képet csinálni
| 6. feladat | LINQ  | 155,9 ns | 256 B | 0,162 | ![](https://i.imgur.com/v8Tx3LP.png)
| | For loop ✅ | 2,09 ns | - | - |
| 9. feladat (615154) | For loop (gyökvonás) ✅ | 859,2 ns | - | - | ![](https://i.imgur.com/Jr84MMM.png)
| 10. feladat | For loop (Euklidészi) ✅ | 4,6 ns | - | - | ![](https://i.imgur.com/xctvPZD.png)
| | LINQ  | 68,63 ns | 120 B | 0,07 |
| 11. feladat | For loop ✅ | 154,8 ns | 136 B | 0,08 | ![](https://i.imgur.com/hWGQBaF.png)