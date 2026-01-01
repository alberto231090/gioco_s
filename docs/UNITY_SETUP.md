# Unity setup & import (prototipo)

Passaggi rapidi per preparare l'ambiente Unity e importare i modelli scaricati:

1. Unity & package:
   - Apri Unity Hub e crea un progetto 3D (consigliato: Unity 2021.3 LTS o 2022 LTS).
   - Apri Package Manager e installa `com.unity.formats.gltf` (se disponibile) oppure importa ``UnityGLTF`` o `GLTFUtility` dalla AssetStore / GitHub.

2. Importare i modelli scaricati (`Assets/Models/`):
   - Se i modelli sono `.glb` o `.gltf`, usa il package GLTF import per convertirli in GameObjects/prefab.
   - Altrimenti, importa `.fbx` direttamente.
   - Controlla materiali e scale (spesso è necessario ridimensionare il modello a scala 0.01 o 1 a seconda dell'origine).

3. Creare prefab
   - Dopo aver importato i modelli come GameObject, trascinali nella cartella `Assets/Prefabs/` per creare prefab riutilizzabili.
   - Associa tag `Child` ai modelli che rappresentano bambini per poterli trovare dal controller.

4. Configurare la scena di prova
   - Segui le istruzioni in `Assets/Scenes/PrototypeScene.md`.
   - Aggiungi `ModelSpawner` (setta i prefab) e `BabysitterController` su un GameObject `Babysitter`.

5. Test rapido
   - Premi Play: dovresti vedere i modelli spawnati e poter usare i tasti P (pick) / R (release) per il prototipo.
   - Verifica animazioni (se presenti) e suoni.

Note tecniche:
- Le licenze dei modelli (es. CC BY 4.0) richiedono attribuzione: mantieni le voci in `docs/LICENSES.md`.
- Per animazioni avanzate e IK considera l'uso di `Unity.Animation Rigging` e `Animator Controller`.

Se vuoi, posso preparare: (A) un import script editor per automatizzare la conversione `.glb` → prefab, oppure (B) procedere manualmente e scrivere i passaggi dettagliati per il tuo ambiente. Rispondi con "A" o "B".