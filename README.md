# ConsoleAdventureGame

Ein Spiel auf der C# Konsole.

## Spielablauf:
- Man startet in der Taverne. Hier kann eine von 3 Quests ausgewählt werden.
- Sobald man sich für eine entschieden hat, kann man sich noch ausrüsten.
- In der Quest erkundet man ein zufällig generiertes Biom.
- Das Biom besteht aus verschiedenen Räumen. Auch Gegner können dich angreifen.
- Im den Räumen lassen sich Gegner, Loot und das gesuchte Questitem finden.
- Sobald man das Questitem gefunden hat, kann man das Biom verlassen.

## Design

### Kämpfe

#### Auswahlmöglichkeiten
- Angreifen
- In defensive Stellung bringen
- Rucksack öffnen und ein Item verwenden/Ausrüstung wechseln
- Fliehen

#### Angrifen
- Schaden basierend auf deiner Waffe und buffs.
- Der Gegner kann abblocken, wenn er sich in defensive Stellung gebracht hat.
- Gute Schilde können automatisch blocken

#### In defensive Stellung bringen
- Der nächste Angriff des Gegners wird reduzierten Schaden verursachen (basierend auf dem ausgerüsteten Verteidigungsgegenstand, nicht die Rüstung)

#### Item verwenden
- Einen Gegenstand aus deinem Rucksack verwenden.
- Das können sein: Trank, Wurfstern, ...

#### Fliehen
- Man kann immer fliehen
- Nach dem Fliehen befindet man sich in den vorigen Raum
