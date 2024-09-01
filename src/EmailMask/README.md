
### Problem Tanımı

Email adreslerinin maskeleme işlemini gerçekleştiren bir fonksiyon tasarlamanız istenmektedir. Bu fonksiyon, belirli karakterlerin görünür olmasını sağlar ve geri kalan karakterleri maskeleyerek e-posta adresinin gizliliğini korur. Fonksiyonun aşağıdaki imzaya sahip olması gerekmektedir:
```csharp
public string MaskEmail(string input, int visibleCharacters, char maskChar, bool staticLength)
```
Fonksiyonun parametreleri ve davranışı aşağıdaki gibidir:

1.  `string input`: Maskeleme işlemi yapılacak olan e-posta adresini temsil eder. Örneğin, `"doga_kocak0623@hotmail.com"`.

1. `int visibleCharacters`: E-posta adresinin başından itibaren kaç karakterin görünür olacağını belirler. Örneğin, bu parametre 2 olarak verildiğinde, çıktı `"do************@hotmail.com"` şeklinde olmalıdır.

2. `char maskChar`: Maskeleme işlemi sırasında kullanılacak karakteri belirtir. Bu karakter, görünmeyen (maskelenmiş) kısmın yerini alır. Genellikle `'*'`, `'#'` gibi karakterler kullanılır. Örneğin, eğer `maskChar` olarak `'*'` belirlenmişse, maskeleme yapılacak tüm karakterler `'*'` ile değiştirilir. Yani, `"doga_kocak0623@hotmail.com"` e-posta adresinin maskelenmiş hali, `"do************@hotmail.com"` şeklinde olacaktır.

3. `bool staticLength`: Bu parametre `true` veya `false` değer alabilir. Eğer true olarak ayarlanırsa, görünür karakterlerden sonra gelen maskelenmiş bölüm sabit bir uzunluğa sahip olacaktır. Bu durumda, gizlenen karakterlerin sayısı sabit olacak şekilde yalnızca `4` adet maskeleme karakteri kullanılır. Örneğin:

   1. ```csharp
        MaskEmail("doga_kocak0623@hotmail.com", 2, "*", true);
        ```
    Bu fonksiyon çağrısı `"do****@hotmail.com"` sonucunu döndürmelidir. Bu özellik, gizlenen karakter sayısının tahmin edilmesini zorlaştırmak için tasarlanmıştır.

### Örnek Kullanımlar
1. ***Görünür Karakter Sayısı: 2, Maskelenmiş Karakter: '*', Sabit Uzunluk: false**
```csharp
MaskEmail("doga_kocak0623@hotmail.com", 2, '*', false);
```
Çıktı: `"do************@hotmail.com"`
1. **Görünür Karakter Sayısı: 2, Maskelenmiş Karakter: '*', Sabit Uzunluk: true**
```csharp
MaskEmail("doga_kocak0623@hotmail.com", 2, '*', true);
```
Çıktı: `"do****@hotmail.com"`

1. **Görünür Karakter Sayısı: 3, Maskelenmiş Karakter: '#', Sabit Uzunluk: false**

```csharp
MaskEmail("doga_kocak0623@hotmail.com", 3, '#', false);
```

Çıktı: `"dog############@hotmail.com"`

Bu fonksiyon, **serendi** e-posta doğrulama işlemlerinde, e-posta adreslerinin maskeleme işlemlerinde kullanılmak üzere tasarlanmıştır ve özellikle gizliliğin korunması gereken durumlarda kullanılacaktır.