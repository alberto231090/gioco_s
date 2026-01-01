# Download & Import istruzioni (Sketchfab, Kenney, Unity Asset Store)

Questo documento descrive come scaricare e importare gli asset approvati per il prototipo.

1) Kenney (se disponibile)
- Cerca l'asset su: https://www.kenney.nl/assets
- Scarica il pacchetto zip (se pubblico) e decomprimilo in `Assets/Models/`
- Aggiungi una riga in `docs/LICENSES.md` indicando il link, la licenza e la data di download

2) Sketchfab (modelli CC0)
- Vai alla pagina del modello (es. i link inseriti in `docs/ASSET_SOURCES.md`)
- Clicca su "Download" → scegli il formato FBX e scarica
- Copia / decomprimi il contenuto in `Assets/Models/<nome-model>`
- Verifica la presenza di textures e materiali e aggiorna `docs/LICENSES.md` con l'URL e licenza

3) Unity Asset Store
- Apri Unity Editor
- Window → Package Manager → My Assets
- Scarica e importalo nella tua versione di Unity
- Non committare i file raw del pacchetto a meno che la licenza lo permetta; invece, tieni istruzioni su come ricreare o ottenere l'asset in `docs/ASSET_SOURCES.md`

4) Checksum e tracciamento
- Esegui: `sha256sum Assets/Models/* > docs/ASSET_CHECKSUMS.txt`
- Aggiungi in `docs/LICENSES.md` i riferimenti ai file e le checksum

---

Se vuoi, posso provare a scaricare automaticamente i file se mi fornisci link diretti ai zip/FBX (se disponibili).