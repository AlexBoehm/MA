# Quellcode zur Masterarbeit

Dieses Git-Repository ist Teil meiner Masterarbeit "Eine Domain Specific Language in C# für Microsoft Blazor in Verbindung mit dem Model View Update Architekturmuster". Es demonstriert die schrittweise Entwicklung einer DSL für Blazor sowie deren Integration mit dem MVU-Architekturmuster.

## Struktur

- `BlazorDSL/`: Beispiel Blazor-Anwendung
- `DSLMethodsGenerator/`: Programm zum Erzeugen verschiedener Methoden der DSL
- `Lib/`: Implementierung der DSL
- `Lib.MVU/`: Implementierung einer Bibliothek für das MVU-Architekturmuster

## Branches
- **master** - [Code anzeigen](../../tree/master): Enthält die README sowie die Implementierung des MVU-Architekturmusters
- **imperativer-ansatz** - [Code anzeigen](../../tree/imperativer-ansatz): Entwicklung des imperativen Ansatz
- **funktionaler-ansatz** - [Code anzeigen](../../tree/funktionaler-ansatz): Entwicklung des funktionalen Ansatz
- **mvu** - [Code anzeigen](../../tree/mvu): Implementierung des MVU-Architekturmusters
- **mvu-ohne-dsl** - [Code anzeigen](../../tree/mvu-ohne-dsl): Implementierung des MVU-Architekturmusters ohne die pure Funktion View (ohne DSL nur mit Standard-Blazor)

## Tags und Commits

Die Masterarbeit referenziert die folgenden Tags, um verschiedene Aspekte zu verdeutlichen und anhand des Quelltextes nachvollziehbar zu machen.

| Tag | Beschreibung |
|-----|-------------|
| aufruf-einer-komponente<br>[Diff](../../commit/aufruf-einer-komponente) \| [Code](../../tree/aufruf-einer-komponente) | Demonstration des Aufrufs einer Blazor-Komponente aus einer anderen Komponente |
| beispiel-einer-komponente<br>[Diff](../../commit/beispiel-einer-komponente) \| [Code](../../tree/beispiel-einer-komponente) | Beispiel einer einfachen Blazor-Komponente |
| beispiel-komponenten-parameter<br>[Diff](../../commit/beispiel-komponenten-parameter) \| [Code](../../tree/beispiel-komponenten-parameter) | Beispiel für die Verwendung von Komponenten-Parametern |
| beispiel-partielle-klassen<br>[Diff](../../commit/beispiel-partielle-klassen) \| [Code](../../tree/beispiel-partielle-klassen) | Beispiel für die Verwendung partieller Klassen |
| beispiel-template-parameter<br>[Diff](../../commit/beispiel-template-parameter) \| [Code](../../tree/beispiel-template-parameter) | Beispiel für die Verwendung von Template-Parametern |
| beispiel-ui-updates<br>[Diff](../../commit/beispiel-ui-updates) \| [Code](../../tree/beispiel-ui-updates) | Beispiel verschiedener UI-Updates |
| dsl-benchmarks<br>[Diff](../../commit/dsl-benchmarks) \| [Code](../../tree/dsl-benchmarks) | Implementierung der Benchmarks |
| entwurf-komponente-funktional<br>[Diff](../../commit/entwurf-komponente-funktional) \| [Code](../../tree/entwurf-komponente-funktional) | Erster Entwurf einer funktionalen Komponente |
| erweiterung-um-div<br>[Diff](../../commit/erweiterung-um-div) \| [Code](../../tree/erweiterung-um-div) | Erweiterung der DSL um das div-Element |
| extension-methods-bedingte-styles<br>[Diff](../../commit/extension-methods-bedingte-styles) \| [Code](../../tree/extension-methods-bedingte-styles) | Implementierung bedingter Styles |
| extension-methods-callerlinenumber<br>[Diff](../../commit/extension-methods-callerlinenumber) \| [Code](../../tree/extension-methods-callerlinenumber) | Verwendung von CallerLineNumber für die Sequenznummern |
| extension-methods-classname-onclick<br>[Diff](../../commit/extension-methods-classname-onclick) \| [Code](../../tree/extension-methods-classname-onclick) | Implementierung von className und onClick |
| extension-methods-foreach<br>[Diff](../../commit/extension-methods-foreach) \| [Code](../../tree/extension-methods-foreach) | Erzeugung von HTML aus Aufzählungen mit ForEach |
| extension-methods-if<br>[Diff](../../commit/extension-methods-if) \| [Code](../../tree/extension-methods-if) | Implementierung bedingter Renderlogik |
| extension-methods-linq<br>[Diff](../../commit/extension-methods-linq) \| [Code](../../tree/extension-methods-linq) | Nutzung von LINQ zur Erzeugung von HTML-Elementen |
| extension-methods-methode-attribute<br>[Diff](../../commit/extension-methods-methode-attribute) \| [Code](../../tree/extension-methods-methode-attribute) | Implementierung der Methode Attribute |
| extension-methods-rudimentäre-dsl-01<br>[Diff](../../commit/extension-methods-rudimentäre-dsl-01) \| [Code](../../tree/extension-methods-rudimentäre-dsl-01) | Erste rudimentäre Version der DSL mit Extension Methods |
| funktional-app-ersetzt<br>[Diff](../../commit/funktional-app-ersetzt) \| [Code](../../tree/funktional-app-ersetzt) | Ersetzung der App-Komponente durch die DSL |
| funktional-arraynode<br>[Diff](../../commit/funktional-arraynode) \| [Code](../../tree/funktional-arraynode) | Implementierung des ArrayNode für mehrere Elemente |
| funktional-beginn-todo-liste<br>[Diff](../../commit/funktional-beginn-todo-liste) \| [Code](../../tree/funktional-beginn-todo-liste) | Beginn der Implementierung einer Todo-Liste mit der DSL |
| funktional-child-content<br>[Diff](../../commit/funktional-child-content) \| [Code](../../tree/funktional-child-content) | Implementierung von Child Content |
| funktional-child-content-neue-methode<br>[Diff](../../commit/funktional-child-content-neue-methode) \| [Code](../../tree/funktional-child-content-neue-methode) | Verbesserte Methode für Child Content |
| funktional-cond<br>[Diff](../../commit/funktional-cond) \| [Code](../../tree/funktional-cond) | Implementierung der Methode cond |
| funktional-demonstration-dependency-injection<br>[Diff](../../commit/funktional-demonstration-dependency-injection) \| [Code](../../tree/funktional-demonstration-dependency-injection) | Demonstration von Dependency Injection |
| funktional-dsl-generator<br>[Diff](../../commit/funktional-dsl-generator) \| [Code](../../tree/funktional-dsl-generator) | Generator für Methoden der DSL |
| funktional-eine-zeile-je-methode<br>[Diff](../../commit/funktional-eine-zeile-je-methode) \| [Code](../../tree/funktional-eine-zeile-je-methode) | Formatierung mit einer Zeile je Methodenaufruf |
| funktional-eine-zeile-tag-und-attribute<br>[Diff](../../commit/funktional-eine-zeile-tag-und-attribute) \| [Code](../../tree/funktional-eine-zeile-tag-und-attribute) | Formatierung mit Tags und Attributen in einer Zeile |
| funktional-empty<br>[Diff](../../commit/funktional-empty) \| [Code](../../tree/funktional-empty) | Methode empty für das Rendern von leerem Inhalt |
| funktional-erste-tags<br>[Diff](../../commit/funktional-erste-tags) \| [Code](../../tree/funktional-erste-tags) | Implementierung der ersten HTML-Tags mit der funktionalen DSL |
| funktional-erweiterung-um-eigene-tags<br>[Diff](../../commit/funktional-erweiterung-um-eigene-tags) \| [Code](../../tree/funktional-erweiterung-um-eigene-tags) | Demonstration der Möglichkeit zur Definition eigener Tags |
| funktional-implementierung-abgeschlossen<br>[Diff](../../commit/funktional-implementierung-abgeschlossen) \| [Code](../../tree/funktional-implementierung-abgeschlossen) | Abschluss der Implementierung der funktionalen DSL |
| funktional-komponente-mit-parameter<br>[Diff](../../commit/funktional-komponente-mit-parameter) \| [Code](../../tree/funktional-komponente-mit-parameter) | Einbindung von Komponenten mit Parametern |
| funktional-komponente-rendermode<br>[Diff](../../commit/funktional-komponente-rendermode) \| [Code](../../tree/funktional-komponente-rendermode) | Angabe des Render Mode  |
| funktional-komponenten-ohne-parameter<br>[Diff](../../commit/funktional-komponenten-ohne-parameter) \| [Code](../../tree/funktional-komponenten-ohne-parameter) | Einbindung von Komponenten ohne Parameter |
| funktional-linq<br>[Diff](../../commit/funktional-linq) \| [Code](../../tree/funktional-linq) | Demo von LINQ mit der funktionalen DSL |
| funktional-onclick<br>[Diff](../../commit/funktional-onclick) \| [Code](../../tree/funktional-onclick) | Implementierung von Event-Handlern wie onClick |
| funktional-optimierung-bindings-eventhandler<br>[Diff](../../commit/funktional-optimierung-bindings-eventhandler) \| [Code](../../tree/funktional-optimierung-bindings-eventhandler) | Optimierung der Methoden von Bindings und Event-Handlern |
| funktional-rendern-von-attributen<br>[Diff](../../commit/funktional-rendern-von-attributen) \| [Code](../../tree/funktional-rendern-von-attributen) | Implementierung von HTML-Attributen |
| funktional-rendern-von-fragmenten<br>[Diff](../../commit/funktional-rendern-von-fragmenten) \| [Code](../../tree/funktional-rendern-von-fragmenten) | Implementierung von Fragmenten |
| funktional-routes-ersetzt<br>[Diff](../../commit/funktional-routes-ersetzt) \| [Code](../../tree/funktional-routes-ersetzt) | Ersetzung der Routes-Komponente durch die DSL |
| funktional-tags-aus-array<br>[Diff](../../commit/funktional-tags-aus-array) \| [Code](../../tree/funktional-tags-aus-array) | Erzeugung von HTML aus Arrays |
| funktional-tags-aus-ienumerable<br>[Diff](../../commit/funktional-tags-aus-ienumerable) \| [Code](../../tree/funktional-tags-aus-ienumerable) | Erzeugung von HTML aus Aufzählungen |
| funktional-tpl-param-mit-kontext<br>[Diff](../../commit/funktional-tpl-param-mit-kontext) \| [Code](../../tree/funktional-tpl-param-mit-kontext) | Implementierung von Template-Parametern mit Kontext |
| funktional-tpl-param-ohne-kontext<br>[Diff](../../commit/funktional-tpl-param-ohne-kontext) \| [Code](../../tree/funktional-tpl-param-ohne-kontext) | Implementierung von Template-Parameter ohne Kontext |
| funktional-vergleich-todo-liste<br>[Diff](../../commit/funktional-vergleich-todo-liste) \| [Code](../../tree/funktional-vergleich-todo-liste) | Vergleich der Todo-Listen-Implementierung zwischen Razor und der DSL |
| funktional-weitere-tags<br>[Diff](../../commit/funktional-weitere-tags) \| [Code](../../tree/funktional-weitere-tags) | Erweiterung um weitere HTML-Tags |
| funktional-zerlegbarkeit<br>[Diff](../../commit/funktional-zerlegbarkeit) \| [Code](../../tree/funktional-zerlegbarkeit) | Demonstration der Zerlegbarkeit von Komponenten |
| generierte-cs-datei<br>[Diff](../../commit/generierte-cs-datei) \| [Code](../../tree/generierte-cs-datei) | Demonstration der generierten C#-Datei aus einer Razor-Komponente |
| generierte-cs-datei-reduziert<br>[Diff](../../commit/generierte-cs-datei-reduziert) \| [Code](../../tree/generierte-cs-datei-reduziert) | Vereinfachte Version der generierten C#-Datei |
| komponente-mit-parameter<br>[Diff](../../commit/komponente-mit-parameter) \| [Code](../../tree/komponente-mit-parameter) | Implementierung von Komponenten-Parametern zur Datenübertragung |
| komponente-mit-template-parameter<br>[Diff](../../commit/komponente-mit-template-parameter) \| [Code](../../tree/komponente-mit-template-parameter) | Verwendung von Template-Parametern |
| methode-mit-html<br>[Diff](../../commit/methode-mit-html) \| [Code](../../tree/methode-mit-html) | Beispiel einer Methode mit HTML im Code-Block |
| methode-mit-html-und-compiler-fehler<br>[Diff](../../commit/methode-mit-html-und-compiler-fehler) \| [Code](../../tree/methode-mit-html-und-compiler-fehler) | Demonstration eines Compiler-Fehlers bei der Verwendung von Render Fragments |
| mvu-blazor-komponenten<br>[Diff](../../commit/mvu-blazor-komponenten) \| [Code](../../tree/mvu-blazor-komponenten) | Demonstration des MVU-Musters mit Razor-Komponenten |
| mvu-commands<br>[Diff](../../commit/mvu-commands) \| [Code](../../tree/mvu-commands) | Implementierung von Commands |
| mvu-delegates<br>[Diff](../../commit/mvu-delegates) \| [Code](../../tree/mvu-delegates) | Definition wichtiger Delegates für die Implementierung von MVU |
| mvu-init<br>[Diff](../../commit/mvu-init) \| [Code](../../tree/mvu-init) | Implementierung der Init-Funktion für den initialen Zustand |
| mvu-messages<br>[Diff](../../commit/mvu-messages) \| [Code](../../tree/mvu-messages) | Definition der Nachrichten als Records |
| mvu-model<br>[Diff](../../commit/mvu-model) \| [Code](../../tree/mvu-model) | Implementierung des Models mit Records |
| mvu-update<br>[Diff](../../commit/mvu-update) \| [Code](../../tree/mvu-update) | Implementierung der Update-Funktion |
| mvu-view<br>[Diff](../../commit/mvu-view) \| [Code](../../tree/mvu-view) | Implementierung der puren View-Funktion mit der DSL |
| projekt-aus-template<br>[Diff](../../commit/projekt-aus-template) \| [Code](../../tree/projekt-aus-template) | Quellcode eines Blazor-Projekts aus dem Standard-Template |
| razor-durch-cs-ersetzt<br>[Diff](../../commit/razor-durch-cs-ersetzt) \| [Code](../../tree/razor-durch-cs-ersetzt) | Ersetzung einer Razor-Komponente durch den erzeugten C#-Code |
