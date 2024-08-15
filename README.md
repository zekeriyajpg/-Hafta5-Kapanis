# 💣  Araba Üretim Programı

Bu program, kullanıcıdan aldığı bilgilerle araba üretimini simüle eder ve oluşturulan arabaları bir listeye kaydeder. Program, araba üretim sürecini kullanıcının girdilerine dayalı olarak gerçekleştirir.

## Program Akışı

1. **Araba Üretim Sorusu:**
   - Program, kullanıcıya araba üretmek isteyip istemediğini sorar.
   - Kullanıcı 'e' (evet) ya da 'h' (hayır) harfi ile yanıt verir. Program, büyük-küçük harf duyarlılığını ortadan kaldırır.
   - Kullanıcı geçersiz bir yanıt verirse, bu geçersizliğin bildirimi yapılır ve tekrar aynı soru sorulur.

2. **Araba Bilgilerinin Girilmesi:**
   - Kullanıcı 'e' cevabını verdiğinde yeni bir `Araba` nesnesi oluşturulur ve aşağıdaki bilgilerin girişi istenir:
     - Seri Numarası
     - Marka
     - Model
     - Renk
     - Kapı Sayısı
   - Kapı Sayısı için sayısal olmayan bir değer girilirse, program uyarı verir ve kullanıcıya yeniden giriş yapma imkanı sunar.

3. **Araba Nesnesinin Listeye Eklenmesi:**
   - Kullanıcının girdiği bilgilerle oluşturulan araba nesnesi, `arabalar` isimli bir listeye eklenir.

4. **Başka Araba Üretimi:**
   - Program, kullanıcıya başka bir araba üretmek isteyip istemediğini sorar. 
   - Eğer kullanıcı 'e' cevabını verirse, aynı süreç baştan tekrarlanır. Kullanıcı 'h' cevabını verirse, program sonlandırılır.

5. **Üretilen Arabaların Listelenmesi:**
   - Program, son olarak üretilen tüm arabaların seri numaralarını, markalarını ve modellerini listeler.

## Kullanılan Teknolojiler

- **C#**: Program, C# dilinde yazılmıştır.
- **.NET**: Programın çalışması için .NET Framework veya .NET Core kullanılması gerekmektedir.

## Nasıl Kullanılır?

1. Programı çalıştırın.
2. Araba üretmek isteyip istemediğinizi belirtin (e/h).
3. Eğer evet derseniz, araba özelliklerini girin.
4. Kapı sayısı sayısal bir değer olmalıdır, aksi takdirde program hata verecektir.
5. Başka bir araba üretmek isterseniz, aynı adımları tekrar edin.
6. Üretim işlemi tamamlandıktan sonra, üretilen arabalar listelenecektir.
