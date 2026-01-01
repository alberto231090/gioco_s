# Demo WebGL — guida rapida 🌐

Questa guida spiega come funziona la pipeline automatica che costruisce e pubblica una demo WebGL del progetto.

Cosa fa il workflow:
- Esegue i test (EditMode e PlayMode)
- Costruisce la scena di esempio `Assets/Scenes/PrototypeScene.unity` in target WebGL
- Pubblica l'output su GitHub Pages (via Actions)

Requisiti prima di spingere i cambiamenti:
- Aggiungere il segreto `UNITY_LICENSE` in GitHub (Settings → Secrets) contenente la tua licenza Unity nei formati richiesti (base64 o come indicato dalla documentazione Unity/game-ci).

Dove verificare la demo:
- Dopo una run di successo, GitHub Pages pubblicherà i contenuti della build; l'URL sarà simile a `https://<owner>.github.io/<repo>/` (verifica nelle impostazioni Pages del repo).

Note pratiche:
- La build WebGL può essere pesante e richiede alcuni minuti.
- Se vuoi, posso:
  - aggiungere una build matrix per più versioni Unity, oppure
  - includere ottimizzazioni di build (compressione, stripping di asset non usati).

Se preferisci, posso abilitare anche la pubblicazione su branch specifico o caricare l'artefatto come release automáticamente.