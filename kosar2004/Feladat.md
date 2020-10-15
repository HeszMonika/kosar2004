# Kosárlabdaliga

## Adatszerkezetek

Egy meccs:
- Meccs nevű osztály
- Adattagok vagy tulajdonságok:
  - Hazai string
  - Idegen string
  - Hazai_pont int (hazai pontok)
  - Idegen_pont int (idegen pontok)
  - Helyszin string
  - Idopont string
- Konstruktor:
  - Meccs(string, string, int, int, string, string)
  - Hazai, Idegen, Hazai_pont, Idegen_pont, Helyszin, Idopont

Meccsek eltárolása:
- Lista --> Meccs objektumok tárolására

## Feladatok:

2. feladat:
- StreamReader (using System.IO;)
- Első sor beolvasása --> nem tároljuk
- Ciklussal végigmegyünk a többi soron
- Ciklusban:
  - Egy sort beolvasunk
  - A sort szétszedjük
  - Listához hozzáadjuk az új objektumot

3. feladat:
- Két változó létrehozása: int hazai, int idegen
- Megszámlálás tétele 2x
- Select

4. feladat:
- Döntetlenek száma --> Megszámlálás tétele vagy Select

5. feladat:
- Kiválasztás tétele vagy Select

6. feladat:
- Kiválogatás tétele vagy Select ("2004-11-21")

7. feladat:
- Megszámlálás tétele --> Dictionary
- Select --> group by