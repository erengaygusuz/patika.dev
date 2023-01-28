# Veri Yapıları ve Algoritmalar

## Selection Sort Projesi

### Proje 1

___[22,27,16,2,18,6] -> Insertion Sort___

___Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.___

[22, 27, 16, 2, 18, 6] 

1.adım => [2, 27, 16, 22, 18, 6] (2 ile 22 değişti)<br>
2.adım => [2, 6, 16, 22, 18, 27] (6 ile 27 değişti)<br>
3.adım => [2, 6, 16, 22, 18, 27] (16 kaldı en küçük)<br>
4.adım => [2, 6, 16, 18, 22, 27] (18 ile 22 değişti)<br>
5.adım => [2, 6, 16, 18, 22, 27] (27 kaldı en küçük, son eleman)<br>

___Big-O gösterimini yazınız.___

Yukarıdaki 1.adımda n değere bakılmış olsun.<br>
2. adımda n - 1 değer.<br>
3. adımda n - 2 değer.<br>
4. adımda n - 3 değer.<br>
5. adımda 1 değer.<br>

1den n'e kadar olan sayıların toplamı $n*(n+1) \over 2$ = $(n^2+n) \over 2$

Burada üssel olarak en büyük olan $n^2$ olduğu için O( $n^2$ )

___Time Complexity: Dizi sıralandıktan sonra 18 sayısı aşağıdaki case'lerden hangisinin kapsamına girer? Yazınız___

___Average case: Aradığımız sayının ortada olması___
___Worst case: Aradığımız sayının sonda olması___
___Best case: Aradığımız sayının dizinin en başında olması.___

18 sayısı ortada olduğu için Average Case.

___[7,3,5,8,2,9,4,15,6] dizisinin Selection Sort'a göre ilk 4 adımını yazınız.___

1.adım => [2,3,5,8,7,9,4,15,6] (2 ile 7 değişti)

2.adım => [2,3,5,8,7,9,4,15,6] (3 kaldı en küçük)

3.adım => [2,3,4,8,7,9,5,15,6] (5 ile 4 değişti)

4.adım => [2,3,4,5,7,9,8,15,6] (8 ile 5 değişti)
