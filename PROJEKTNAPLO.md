# Projektnapló – Konzolos rajzoló

## Csapat és munkamegosztás

|Név vagy GitHub-felhasználónév|Vállalt feladatok és szerep|Saját menüfunkció|
|-|-|-|
|Órendi Göncöl|A rajzlap adatainak tárolása tömbökben és a rajzlap kirajzolása; a bal oldali állapotjelző panel; a rajzlap szélének ellenőrzése és hangjelzés hibánál; a vezérlési súgók kiírása; az aktív menüpont kiemelése és a hibás menügomb jelzése; a rajzszín választása a menüből; az F1–F12 billentyűk bekötése a nyomdákhoz; a két saját menüfunkció feltöltése.|Ugrás középre|
|Szabó Bence Kálmán|A projekt inicializálása és a projektnapló feltöltése; az alap konzolablak, az elválasztó vonal és a rajzlap fejléc; a kurzor pozíciója, a kezdeti állapotok és a látható kurzor; a program fő ciklusa és a nyílbillentyűs kurzormozgatás; az eszköz állapotának váltása szóközzel és a szabadkézi rajzolás; a menü állapota és a fel/le nyilas navigáció Esc-kel; a rajzkarakter választása a menüből; a nyomdák (X, kereszt, négyzet, rombusz; 3×3, 5×5 és 7×7 méretben).|Cella törlése|

A két saját menüfunkció: a **Cella törlése** az aktuális cellát üres karakterre és fehér színre állítja, az **Ugrás középre** a kurzort a rajzlap közepére teszi.

## Közös megállapodások

* A rajzlap mérete és helye: A rajzlap mérete az ablakhoz igazodik (legalább 60×22): a bal oldali panel a szélesség harmada, a rajzlap a jobb oldalon, a panel után 2 oszloppal és a 2. konzolsorban kezdődik. A koordináták 0-tól számozódnak, a bal felső cella a (0, 0), a konzolpozíció a rajzlap kezdőpontja plusz az `x` és az `y`.
* A két munkarész kapcsolódási pontja: Mindkét rész ugyanabban a `Program.cs` fájlban, közös változókon keresztül kapcsolódik: a rajzlap helye és mérete, a kurzor pozíciója (`x`, `y`), az aktuális karakter, szín és eszközállapot, valamint a rajzlap tartalmát tároló két tömb (`lapKarakter`, `lapSzin`). A mozgatás, a nyomdák, a fájlbetöltés és a saját menüfunkciók ugyanezekbe a tömbökbe írnak, a hibákat pedig mindenhol ugyanaz a `Hiba` metódus jelzi.
* A módosítások egyeztetése a main ágon: A projekt alapját (kezdőprojekt, projektnapló, alap konzolablak) Szabó Bence Kálmán töltötte fel. Utána 2026. 11. 22-én ketten, kisebb lépésekben dolgoztunk egymás mellett: a commitok időrendben keverednek Bence és Göncöl között, és a commitüzenetek alapján külön részfeladatokon dolgoztunk (Bence: mozgatás, rajzolás, menünavigáció, karakterválasztás, nyomdák; Göncöl: rajzlap, állapotjelző, szél- és hibajelzés, súgók, szín, F-billentyűk).

## Munkanapló

|Dátum|Ki|Mi készült el vagy miben állapodtunk meg?|Következő lépés vagy commit|
|-|-|-|-|
|2026. 11. 12.|Szabó Bence Kálmán|Elkészült a projekt inicializálása.|Projektnapló|
|2026. 11. 12.|Szabó Bence Kálmán|Felkerült a projektnapló a projektbe.|Alap konzolablak, elválasztó és rajzlap fejléc létrehozása|
|2026. 11. 22.|Szabó Bence Kálmán|Elkészült az alap konzolablak, az elválasztó és a rajzlap fejléc.|Rajzlap tömbök létrehozása és kirajzolása|
|2026. 11. 22.|Órendi Göncöl|Létrejöttek a rajzlap tömbjei és a rajzlap kirajzolása.|Állapotjelző panel a bal oldalon|
|2026. 11. 22.|Órendi Göncöl|Elkészült a bal oldali állapotjelző panel.|Rajzlap szélének ellenőrzése és hiba beep hangjelzés|
|2026. 11. 22.|Órendi Göncöl|Megvalósult a rajzlap szélének ellenőrzése és a hiba beep hangjelzés.|Kurzor pozíció, kezdeti állapotok és látható kurzor létrehozása|
|2026. 11. 22.|Szabó Bence Kálmán|Létrejött a kurzor pozíciója, a kezdeti állapotok és a látható kurzor.|Vezérlési súgók kiírása a bal oldali panelen|
|2026. 11. 22.|Órendi Göncöl|Megjelentek a vezérlési súgók a bal oldali panelen.|Aktív menüpont kiemelése és hibás menügomb jelzés|
|2026. 11. 22.|Órendi Göncöl|Elkészült az aktív menüpont kiemelése és a hibás menügomb jelzése.|Fő ciklus és nyílbillentyűs kurzormozgatás létrehozása|
|2026. 11. 22.|Szabó Bence Kálmán|Létrejött a fő ciklus és a nyílbillentyűs kurzormozgatás.|Rajzszín választása a menüből|
|2026. 11. 22.|Órendi Göncöl|Elkészült a rajzszín választása a menüből.|Eszköz állapot váltása szóközzel és szabadkézi rajzolás|
|2026. 11. 22.|Szabó Bence Kálmán|Megvalósult az eszköz állapot váltása szóközzel és a szabadkézi rajzolás.|F1-F12 billentyűk bekötése a nyomdákhoz|
|2026. 11. 22.|Órendi Göncöl|Az F1–F12 billentyűk be lettek kötve a nyomdákhoz.|Két saját menüfunkció (cella törlés és ugrás középre)|
|2026. 11. 22.|Órendi Göncöl|Elkészült a két saját menüfunkció: cella törlés és ugrás középre.|Menü állapot és navigáció fel/le nyilakkal és Esc-kel|
|2026. 11. 22.|Szabó Bence Kálmán|Elkészült a menü állapot és a navigáció fel/le nyilakkal és Esc-kel.|Rajzkarakter választása a menüből|
|2026. 11. 22.|Szabó Bence Kálmán|Megvalósult a rajzkarakter választása a menüből.|Nyomdák (X, kereszt, négyzet, rombusz) 3x3, 5x5 és 7x7 méretben|
|2026. 11. 22.|Szabó Bence Kálmán|Elkészültek a nyomdák (X, kereszt, négyzet, rombusz) 3x3, 5x5 és 7x7 méretben.|Szöveges minta betöltése méret- és fájlellenőrzéssel|
|2026. 11. 22.|Szabó Bence Kálmán|Elkészült a szöveges minta betöltése méret- és fájlellenőrzéssel.|Kilépés menüpontból és konzol állapot visszaállítása|
|2026. 11. 22.|Szabó Bence Kálmán|Megvalósult a kilépés menüpontból és a konzol állapot visszaállítása.|Merge: saját és társammal közös fejlesztések|
|2026. 11. 22.|Órendi Göncöl|Megtörtént a saját és társammal közös fejlesztések merge-ölése.|– (ez az utolsó commit a listában)|

## Másik pár tesztje

* Tesztelt commit: …
* Visszajelzés és saját javítás: …
* Újrateszt eredménye: …

## Otthoni AI-használat

Aki használt AI-t, írja le a nevét, miben kért segítséget, és mit tanult meg belőle.

* Név: Órendi Göncöl és Szabó Bence Kálmán
* Miben kértem segítséget: tömbök (egy- és kétdimenziós), az ablak méretének lekérdezése és a kurzor elrejtése, színek kezelése (`ConsoleColor`), `char.IsControl`, `Math.Abs`, fájlbeolvasás (`File.Exists`, `File.ReadAllLines`), `try` és `catch`, valamint a `null` ellenőrzése. Az iskolában már tanult dolgokhoz (pl. változók, `if`, ciklusok, operátorok, szövegkezelés, metódusok, billentyűbekérés, hangjelzés, kurzorpozíció, képernyőtörlés, `static` változók) nem kértünk AI-t.
* Mit tanultam meg:
  * **Tömbök:** több azonos típusú érték egy változóban, 0-tól indexelve. A kétdimenziós tömb táblázatszerű (`lapKarakter[sor, oszlop]`): a rajzlap karaktereit és színeit két ilyen tömb tárolja.
  * **Konzol:** a `Console.CursorVisible = false` elrejti a villogó kurzort, a `Console.WindowWidth` és a `Console.WindowHeight` az ablak méretét adja, ebből számoljuk a panelek méretét.
  * **Színek:** a `ConsoleColor` előre megadott színnevek típusa (enum). A `ForegroundColor` a betűszínt, a `BackgroundColor` a hátteret állítja, a `ResetColor()` visszaállítja az alapot.
  * **`char.IsControl`:** megmondja, hogy a karakter vezérlőkarakter-e (pl. Enter), amit nem lehet kirajzolni. A karakterválasztásnál ezt szűrjük ki.
  * **`Math.Abs`:** az abszolút érték, vagyis az előjel nélküli távolság. A nyomdáknál a középponttól mért távolságot vizsgáljuk vele (pl. rombusz: `Math.Abs(dx) + Math.Abs(dy) == r`).
  * **Fájlbeolvasás:** a `File.Exists` megmondja, hogy létezik-e a fájl, a `File.ReadAllLines` pedig soronként beolvassa egy `string[]` tömbbe (a `using System.IO;` kell hozzá).
  * **`try`, `catch` és `null`:** ha a `try` blokkban hiba történik, a program nem áll le, hanem a `catch` ágon folytatódik. A `null` azt jelenti, hogy nincs érték (a `Console.ReadLine()` is adhat ilyet), ezért ellenőrizzük.