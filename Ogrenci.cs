public class Ogrenci
{
    public int id;
    public string name;

    public string surname;

    public int age;

    public int schoolNo;

    // bu nesneyi farklı bilgiler ile belleğe çıkartmak isteyebiliriz
    // sadece ad vererek,
    // sadece soyad vererek,
    // sadece id vererek
    // yada sadece yaş vererek
    // her bir değişken için bir ctor yazalım


    // Ctorları birbirlerine yönlendirme işlemi yapabiliriz
    // Bir ctor'u çalışmaya başlamadan önce başka bir ctor'a yönlendirebilir ve o ctor'un çalışması bittiken sonra 
    // geri istediğimiz ctor'u çalıştırabilirz

    // bu işlemi ctorlar arası parametre göndererekte yapabiliriz

    public Ogrenci(){

        // tüm öğrencilerde aynı okul no olur
        this.schoolNo=115;

    }
    public Ogrenci(int id):this()
    {
        this.id = id;
    }
    public Ogrenci(int id,string name):this(id){

        //this.id = id;
        this.name = name;

    }

    
    public Ogrenci(int id, string name,string surname):this(id,name){

        //this.id = id;
        //this.name=name;
        this.surname = surname;

    }

    // this ifadesi ile iki parametre alan ctor'a yönlendirdik
    public Ogrenci(int id,string name,string surname,int age):this(){

        // id paramtresi alan ctor'a yönlendirme sebebi ile id değerini burada atamaya gerek yok 
        //this.id = id;
        //this.name=name;
        //this.surname=surname;
        this.age = age;
    }
}