Acesta este un program ce va calcula diferenta de varsta dintre doua persoane
Programul utilizeaza atat metode ale clasei Math cat si ale clasei String.

Am creat o noua clasa si am numit-o "Person".Inauntrul acestei clasei se gasesc 4 campuri si anume si 4 proprietati corespunzand acetora:
	-3 string-uri:firstname,lastname,fullname
	-un intreg:age
Proprietatea FullName este folosita pentru a returna concatenarea proprietatilor FirstName si LastName

In functia main am instantiat doua obiecte pentru clasa Person, si anume person1 si person2.

Pentru realizarea programului am folosit 3 metode:
	-getName:Returneaza un string ce se presupune a fi numele utilizatorului
	-getAge:Returneaza varsta utilizatorului
	-isOlder:Verifica daca primul argument este mai mare decat al doilea, folosind metoda Max a Clasei Math

In interiorul lui main am impartit string-ul returnat de metoda getName, folosind metoda Split a clasei String, iar apoi am atribuit numelui de familie si preunmelui fiecarei persoane valoarea gasita la primul indice al vectorului de string-uri, respectiv la al doilea.
Am atribuit varstei fiecarei persoane valoarea returnata de getAge
Apoi am care persoana este mai mare, calculand diferenta folosind metoda Abs a clasei Math si facand afisarea.
