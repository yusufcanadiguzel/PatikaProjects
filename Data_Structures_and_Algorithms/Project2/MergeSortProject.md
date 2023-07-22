# Proje 2
### [16, 21, 11, 8, 12, 22] -> Merge Sort

*****

**Soru :** Yukarıdaki dizinin sort türüne göre aşamalarını yazınız.

**Cevap :** 

#### Aşama 1
```
16, 21, 11 | 8, 12, 22
```

#### Aşama 2
```
16, 21 - 11 | 8, 12 - 22
```

#### Aşama 3
```
16 - 21 - 11 | 8 - 12 - 22
```

#### Aşama 4
```
16, 21 - 11 | 8, 12 - 22
```

#### Aşama 5
```
11, 16, 21 | 8, 12, 22
```

#### Aşama 6
```
8, 11, 12, 16, 21, 22
```
\
**Big-O Sonucu :** O(nlog(n)) 