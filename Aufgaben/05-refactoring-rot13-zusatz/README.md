# ROT-13
## Function Kata „ROT-13“  
Schreibe eine Funktion, die einen Text mit dem Verfahren ROT-13 verschlüsselt.  

Bei ROT-13 wird jeder Buchstabe des zu verschlüsselnden Textes durch den ersetzt, der 13 Stellen weiter hinten im Alphabet liegt. Sollte dabei über das Alphabetende hinausgegriffen werden, geht es am Anfang weiter.

**Beispiel: Hello, World -> URYYB, JBEYQ**  

Aus „e“ wird „R“ und aus „W“ wird „J“. Kleinbuchstaben werden in Großbuchstaben verwandelt.

Umlaute müssen vor Verschlüsselung durch Buchstabenkombinationen ersetzt werden: „Ö“ = „OE“, „Ä“ = „AE“, „Ü“ = „UE“, „ß“ = „SS“.

Zeichen die keine Buchstaben sind, werden nicht verschlüsselt.

**Variation #1**  
Mache den Versatz (hier: 13) variabel.

**Variation #2**  
Verschlüssele auch Ziffern. Nimm dafür an, dass Ziffern und Großbuchstaben eine Einheit bilden: 0123456789ABCDEFGH…XYZ.

Aus „0“ wird dann mit Versatz 13 „D“ und aus „Z“ wird dann nicht mehr „M“, sondern „C“.