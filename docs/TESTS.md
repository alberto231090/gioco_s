# Eseguire i test automatici (Unity Test Runner)

Questa guida spiega come eseguire i test di unità e PlayMode che ho aggiunto al progetto.

Tipi di test inclusi:
- EditMode: `Assets/Tests/EditMode/*` (es.: `ModelSpawnerTests`, `DebugUITests`)
- PlayMode: `Assets/Tests/PlayMode/*` (es.: `BabysitterControllerTests`)

Esecuzione nell'Editor Unity:
1. Apri il progetto in Unity e attendi che gli asset vengano importati.
2. Vai a `Window -> General -> Test Runner`.
3. Nella finestra Test Runner puoi eseguire singoli test o "Run All" per eseguire tutti i test.

Esecuzione da linea di comando (headless):
- Esempio (Linux/macOS):
  unity -batchmode -runTests -projectPath <path-to-project> -testResults path/to/results.xml -logFile -

Note:
- I test PlayMode sono test che richiedono il Play Mode e girano nella scena di test.
- Se aggiungi nuove funzionalità, crea test corrispondenti per coprire i comportamenti critici (spawning, picking/releasing, aggiornamento UI).

## Continuous Integration (GitHub Actions) ✅

Ho aggiunto un workflow di esempio in `.github/workflows/unity-tests.yml` che esegue i test EditMode e PlayMode su ogni push e PR verso `main`.

Cosa serve per attivarlo:
- Aggiungere il segreto `UNITY_LICENSE` nel repository (GitHub Settings → Secrets) contenente la licenza Unity in formato base64 o come richiesto dalle indicazioni ufficiali (vedi documentazione Unity su come esportare la licenza personale).
- Il workflow usa `game-ci/unity-test-runner@v2` e carica i risultati in `TestResults` come artifact.

Se vuoi, posso:
- adattare il workflow per più versioni Unity (matrix), o
- aggiungere report JUnit più strutturati e integrazione con GitHub Checks.

Se vuoi che aggiunga il CI ora (incluso il ritegno della licenza o la configurazione matrix), dimmelo e lo implemento.