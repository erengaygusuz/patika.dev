# Veri Yapıları ve Algoritmalar

## Merge Sort Projesi

### Proje 2

___[16,21,11,8,12,22] -> Merge Sort___

___Yukarıdaki dizinin sort türüne göre aşamalarını yazınız.___
___Big-O gösterimini yazınız.___

1.adım => [16,21,11] &nbsp; [8,12,22] <br>
2.adım => [16,21] &nbsp; [11] &nbsp; [8,12] &nbsp; [22] <br>
3.adım => [16] &nbsp; [21] &nbsp; [11] &nbsp; [8] &nbsp; [12] &nbsp; [22] <br>
4.adım => [16, 21] &nbsp;  [8, 11] &nbsp; [12, 22] <br>
5.adım => [8, 11, 16, 21] &nbsp; [12, 22] <br>
6.adım => [8, 11, 12, 16, 21, 22] <br>

O(n * log n)
