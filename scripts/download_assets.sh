#!/usr/bin/env bash
set -euo pipefail

# download_assets.sh
# Script di supporto per scaricare asset utilizzabili per il prototipo.
# Nota: alcuni siti (Sketchfab, Unity Asset Store) richiedono login o interazione manuale.
# Questo script automatizza i download diretti quando possibile e fornisce istruzioni per i download manuali.

OUTDIR="$(pwd)/Assets/Models"
mkdir -p "$OUTDIR"

echo "Directory di output: $OUTDIR"

echo "\n--- PASSO 1: Kenney (se disponibile tramite link diretto) ---"
# Esempio: se hai un link diretto al file zip lo puoi aggiungere qui e lo script lo scaricherà.
# Per esempio: KENNEY_URL="https://www.kenney.nl/assets/your-asset/download/12345/zip"
# curl -L "$KENNEY_URL" -o "$OUTDIR/kenney-kids.zip"

echo "Controlla il sito Kenney per il pacchetto desiderato e scaricalo manualmente se necessario: https://www.kenney.nl/assets"

echo "\n--- PASSO 2: Sketchfab / modelli CC0 ---"
# Sketchfab spesso richiede l'interazione utente (download button). Fornisci qui i file scaricati manualmente.
# Esempio: posiziona i file scaricati (fbx / zip) in Assets/Models/, poi esegui:
# unzip Assets/Models/model-sample.zip -d Assets/Models/

echo "Per Sketchfab: visita la pagina del modello, clicca Download -> select format FBX, salva e sposta il file in Assets/Models/."

echo "\n--- PASSO 3: Unity Asset Store ---"
# Unity Asset Store non permette sempre di ridistribuire i file raw. Scarica tramite l'Editor Unity -> Window -> Package Manager -> My Assets.
# Poi esporta un pacchetto Unity o usa localmente.

cat <<'EOF'
Suggerimenti:
- Una volta scaricati gli asset (zip/fbx), decomprimili in Assets/Models/ e aggiungi un file README.md con licenza e link (vedi docs/LICENSES.md)
- Per verificare checksum (consigliato):
    sha256sum Assets/Models/* > docs/ASSET_CHECKSUMS.txt
- Se vuoi che lo script tenti un download diretto, modifica le variabili KENNEY_URL, SKETCHFAB_URL con link diretti e decommenta i comandi curl.
EOF

echo "Script completato. I file da scaricare manualmente sono elencati nelle istruzioni."