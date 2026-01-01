## Esempio: setup automatico scena prototipo ✅

Questo documento spiega come generare automaticamente una scena di esempio in Unity usando lo script editor incluso nel repository.

Requisiti:
- Aprire il progetto in Unity (versione consigliata: 2021/2022 LTS)
- Assicurarsi di avere i modelli in `Assets/Models` (ad es. i .glb/.gltf scaricati in precedenza)
- Importare il package per glTF se necessario (es. UnityGLTF o il pacchetto ufficiale)

Come eseguire:
1. Apri Unity e attendi che l'AssetDatabase importi i modelli.
2. Vai al menu: `Tools -> Babysitter -> Setup Example Scene`.
3. Lo script creerà una scena `Assets/Scenes/PrototypeScene.unity`, creerà prefab in `Assets/Prefabs` per ogni modello trovato in `Assets/Models`, aggiungerà `ModelSpawner`, un `Babysitter` con `BabysitterController` e una UI di debug.
4. Apri la scena `Assets/Scenes/PrototypeScene.unity` e premi Play.

Cosa verificare:
- I modelli sono stati convertiti in prefab sotto `Assets/Prefabs`.
- `SceneManager` contiene lo script `ModelSpawner` e ha i prefab assegnati.
- `Babysitter` ha lo script `BabysitterController` con `HoldPoint` impostato.
- La UI mostra un `DebugText` sulla schermata.

Note:
- Lo script non modifica i tuoi file esistenti oltre a creare prefab e la scena; puoi adattarlo liberamente.
- Se i tuoi modelli non appaiono, assicurati che Unity abbia finito l'import e che i file in `Assets/Models` siano importati come GameObject (non come texture o altro).

Se vuoi, posso aggiungere comandi per spawnare automaticamente o per collegare animazioni (es. Mixamo) via script.
