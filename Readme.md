# Solid Prensipleri

### Single Responsibilty
Bir sınıf veya metot sadece tek bir amaç doğrultusunda kullanılmalıdır. Örneğin genel anlamda matematik classı içerisinde matematiğe ait amaçlar olmalıdır. Matematik sınıfı içerisinde türkçe dersiyle ile ilgili bir metot veya başka bir amaç bu prensibi sağlamaz duruma getirmektedir.

### Open-Closed Principle
Gelişime açık ancak değiştirmeye kapalı prensibi diyebiliriz. Bir sınıfta değişiklik yapmak istediğimizde ona bağlı tüm sınıflarda da eklemeler çıkarmalar vs. yapılıyorsa bu prensibe aykırı demektir. Değiştirmeden yeni özellik kazanılması gerekmektedir.
 
### Liskov Substitution Principle
 Alt sınıftaki nesnelerle kalıtım alınan nesneler arasında değişiklik yapıldığında problem olmadığı zaman bu prensip sağlanmaktadır.
 
### Interface Segregation Principle
 İnterfaceler birden fazla amaca ait özellik bulunmamalıdır. Tek bir amacın özelliklerini barındırmalıdır.

 ### Dependency Inversion Principle
Bağımlılıklar yok edilmelidir. Yani bir noktadan sorun olduğunda sadece o noktada değişiklikler yapılabilmelidir. Ana sınıf alt sınıflara bağımlı olmamalı. Örneğin laptop fanın değiştirilmesi için anakartın sökülmesinin gerekmediği gibi bir örnek verilebilir.
