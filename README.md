# Julenissens lister

### Om prosjektet

Fra Kodehode har vi fått oppgave med å hente inn en rekke tilfeldig genererte mennesker og skal fordele disse inn i snill og slem liste for julenissen.
Det er 5 alver som vi selv har laget, som skal lage gaver til de som har vært snill. Hver alv skal ha et relevant navn og spesialitet.
De som har vært slem får kull, men det skal være en 10% sjanse for at de blir tatt av Gryla.


### Kodere

[Christian](https://github.com/amhc082024)<br>
[Ian](https://github.com/Jonesey86)<br>
[Michael](https://github.com/SAM082024)<br>
[Oliver](https://github.com/Tobe-Deleted)<br>


### Hvem er ansvarlig for hva?

Christian er sjef for program.cs hvor han deserializer .json filen med alle menneskene. De blir delt opp i snill og slem, basert på deres egenskaper, og sendt videre i lister til funksjonene NaughtyList og NiceList.
Han står også for dictionaries.cs som inneholder dictionaries som brukes for å tildele morality points til hvert menneske. Dette er scoren som blir brukt for å fordele dem i snill og slem.

Ian er sjef for Alvene. Der har han laget en modell i Elf.cs og CreateElf funksjonen i functions.cs. 
I tillegg har han ansvar for NiceList funksjonen. Det er en funksjon som først kaller alvene fra CreateElf, og så fordeler alvene og en gave fra den alven til hvert menneske. Til slutt printes hele listen ut med navn, alv og gave.

Michael er sjef for NaughtyList. Her får barna enten tildelt kull eller Gryla. Hva man får bestemmes av en RNG som gir et tall fra 0-9. Det er 10% sjanse for at et barn får Gryla.
NaughtyList printer også ut listen med Navn og straff(kull eller Gryla).

Oliver er gruppeleder. Han har lagt planen, laget flytdiagrammet, fordelt arbeidet, styrt github og hjulpet de 3 andre på riktig spor når det trengs.
