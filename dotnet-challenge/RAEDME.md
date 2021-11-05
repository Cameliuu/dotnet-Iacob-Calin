Acest program a avut ca scop exersarea notiunilor de:
						     colectii(predate in cadrul workshop-ului de ieri (4.11.2021)),
						     clase
						     metode

La rularea programului suntem intampinati cu un meniu ce ne permite urmatoarele urmatoarele functonalitati:
	
	Inregistrarea unui email
			Este posibila mereu atata timp cat programul ruleaza
			Pentru a verifica daca adresa de email este corecta, programul se foloseste de notiunea de expresii regulate pentru a verifica existenta unui anumit pattern in 																					adresa introdusa.
			Din pacate, nu am reusit sa inteleg aceasta notiune atat de bine, astfel programul nu recunoasta pattern-urile de genul nume.prenume@adresa.com ca fiind valide
			De altfel programul verifica si daca adresa introdusa este deja asociata unui cont.
	
	Logare
			Utilizatorul se poate loga daca cunoaste credentialele unui cont (numele si email-ul).
			Verificarea pentru valabilitatea email-ului introdus este realizata folosind metoda Trim() a clasei String.
			Daca utilizatorul este logat, la aparitia meniului acesta este intampinat de numele si emai-ul asociat contului.
			Daca utilizatorul nu este logat, acesta este informat la aparitia meniului privind acest fapt.
	
	Delogare
			Utilizatorul are posibilitatea de a se deloga, in cazul in care acesta este logat
			Daca acesta nu este logat, va fi informat de acest fapt, fiindu-i restrictionat accesul acestei facilitati
			
	Stergere
			In cazul in care utilizatorul este logat, acesta are posibilitatea de a-si sterge contul.
			In cazul in care utilizatorul nu este logat, i se restrictioneaza accesul acestei facilitati.
			
	Afisare
			Utilizatorul poate afisa in orice moment conturile inregistrate pana la momentul accesarii acestei facilitati.
