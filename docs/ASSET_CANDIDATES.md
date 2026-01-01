# Candidate modelli FBX gratuiti (bozza)

Ho preparato una lista di fonti e le specifiche che cerco; selezionerò asset specifici (link + licenza) non appena confermi questa bozza.

## Specifiche richieste per gli asset
- Tipo: personaggi (bambini, genitori, babysitter) e props (divano, letto, auto, pannolino, giocattoli)
- Numero target iniziale: 6 personaggi + 6 props
- Età/ruoli proposti: Bambino A (3 anni), Bambino B (6 anni), Genitore madre, Genitore padre, Babysitter (tu), Personaggio secondario/eventuale
- Rig: umanoide, compatibile con Mixamo o con animation retargeting di Unity/Unreal
- Animazioni incluse o compatibili: idle, walk, run, sit, pick_up, carry, console (pat), cry (anim + audio), sleep, change_diaper (animazione non esplicita)
- Licenza: preferenza per CC0 o CC BY (con attribuzione). Evitare asset con restrizioni di ridistribuzione.

## Fonti primarie (da cercare asset specifici)
1. Mixamo (Adobe) — personaggi riggati + ampia libreria di animazioni, scaricabile come FBX
2. Sketchfab — filtra per "downloadable" e licenza CC0/CC-BY
3. Unity Asset Store (sezione Free) — cercare "kids character" e "humanoid"
4. Free3D / TurboSquid — modelli gratuiti verificando licenza
5. OpenGameArt — modelli e animazioni con licenze permissive
6. Kenney.nl — props gratuiti (2D/3D) per ambiente

## Proposta di asset (bozza di selezione - confermare prima di scaricare)
- 2x bambini (3y, 6y) • humanoid rigged • variante etnica casuale
- 2x genitori (uomo/donna) • adulto • rigged
- 1x babysitter (teen/adult) • rigged
- 6 props: divano, letto singolo, seggiolino auto, pannolino, cassettina giocattoli, tappeto

## Animazioni e audio
- Pacchetti Mixamo per base animations (idle, walk, pickup)
- Animazioni specifiche: crying (loop), consoling (short pat), sitting_on_lap (blend), change_diaper (gesture non esplicita)
- Effetti sonori: pianto bimbo, ringraziamento genitore, ambient sounds

## Controlli e scelta IA per caratteristiche
Hai richiesto che l'IA decida etnie/ruoli: procedo impostando una distribuzione bilanciata (es. 50% etnia A, 25% B, 25% C) e generando nomi e background semplici per ciascun personaggio.

---

Se approvi questa bozza, procedo a:
1) trovare 10 asset specifici con link e licenza e inserirli in `docs/LICENSES.md`,
2) scaricarne i file e importarli in `Assets/Models` (dopo approvazione tua per ciascun asset),
3) testare import e animazioni in una scena di prova.

Rispondi: "approvo" per procedere con la ricerca dettagliata e il download, o indica modifiche.
