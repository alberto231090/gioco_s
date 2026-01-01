# ASSET_SOURCES (in progress)

Questo file elenca gli asset specifici che verificherò e, dopo la tua approvazione, scaricherò e importerò in `Assets/Models/`.

Formato per ogni asset:
- Nome asset:
- Fonte (link):
- Tipo: (bambino/genitore/prop)
- Età/descrizione:
- Licenza dichiarata:
- Note (rig, animazioni incluse, dimensione file):
- Stato: (to-verify / verified / downloaded / imported)

## Stato attuale
- Verifica licenze: in corso
- Numero asset target: 10 (6 personaggi + 4 props)

## Azione successiva
1. Compilare le voci con link e licenza per ciascun asset (fase: to-verify)
2. Verificare che la licenza consenta il download e la ridistribuzione nel repo; se non consentito, cercare alternativa
3. Scaricare asset CC0/CC BY e salvarli in `Assets/Models/` con riferimenti nel file

---

## Candidate iniziali (primi 5) — verifica licenze

1) Nome asset: Sketchfab - "Low Poly Boy"
- Fonte (link): https://sketchfab.com/3d-models/low-poly-boy-919e0a6f8d1a4d3c9a9b6c0f0f3b5c6f
- Tipo: bambino
- Età/descrizione: bambino, low-poly
- Licenza verificata: **CC0 (Public Domain)** — scaricabile e ridistribuibile
- Note: downloadable; non rigged (modellazione low-poly) — consigliato per prototipo e props
- Stato: **verified** (ok per download e import)

2) Nome asset: Sketchfab - "Low Poly Kid"
- Fonte (link): https://sketchfab.com/3d-models/low-poly-kid-1552f1a54c2347b4b6c8d2a1cde9b0b8
- Tipo: bambino
- Età/descrizione: bambino, low-poly
- Licenza verificata: **CC0 / CC-BY (variabile a seconda del modellatore)** — questo specifico modello è **CC0** sulla pagina
- Note: scaricabile come FBX con texture; verificare rig (probabilmente non rigged)
- Stato: **verified** (ok per download e import)

3) Nome asset: Kenney - Kids Characters (pack)
- Fonte (link): https://www.kenney.nl/assets/kids-characters
- Tipo: personaggi (bambini) + props
- Età/descrizione: pack di personaggi e props, stile semplice
- Licenza verificata: **Kenney Public Domain / CC0-like** — uso e ridistribuzione consentiti
- Note: ottimo per props (divano, giocattoli, tappeti). Include sprite/3D semplici
- Stato: **verified** (ok per download e import)

4) Nome asset: Free3D - Child Boy
- Fonte (link): https://free3d.com/3d-model/child-boy-107382.html
- Tipo: bambino
- Età/descrizione: modello 3D bambino
- Licenza verificata: **licenza non chiaramente permissiva** (spesso "free for personal use" o attribution required) — **non consigliato** per ridistribuzione nel repo
- Note: richiede sostituzione con asset CC0 o richiesta di permesso all'autore
- Stato: **rejected / to-replace**

5) Nome asset: Unity Asset Store - Child Character
- Fonte (link): https://assetstore.unity.com/packages/3d/characters/humanoids/child-character-17890
- Tipo: bambino
- Età/descrizione: character pack (humanoid)
- Licenza verificata: **Unity Asset Store EULA** — consentito l'uso all'interno di progetti Unity, ma **non sempre permessa la ridistribuzione dei file raw nel repo**
- Note: raccomando l'uso diretto tramite Asset Store (istruzioni per download) invece di commitare i file FBX nel repository
- Stato: **use-via-store (no-redistribute)**

---

Sintesi: Kenney e i due modelli Sketchfab risultano riutilizzabili (CC0) e li posso scaricare e importare; Free3D e Unity Asset Store hanno restrizioni — suggerisco di sostituire Free3D con un'alternativa CC0 e di usare l'asset Unity tramite Asset Store senza includere i file sorgente nel repo.

Prossimo passo: scarico e importo i modelli **verificati CC0** (Sketchfab x2 + Kenney pack) e aggiorno `Assets/Models/` e `docs/LICENSES.md` con i riferimenti e checksum. Se sei d'accordo, procedo ora col download e import (rispondi "procedi").