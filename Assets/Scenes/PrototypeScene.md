# Prototype Scene - istruzioni

Questa è una guida per ricreare la scena di prototipo in Unity (passaggi manuali):

1. Apri Unity (versione consigliata 2022.x o successiva).
2. Crea una nuova scena `PrototypeScene` nella cartella `Assets/Scenes/`.
3. Aggiungi una `Directional Light` e una `Camera` principale.
4. Crea un empty GameObject chiamato `SceneManager` e aggiungi il componente `ModelSpawner`.
   - Imposta nella inspector la lista `models` con i prefab dei modelli importati (vedi `Assets/Models/`).
   - Puoi definire `spawnPositions` per posizionare automaticamente i modelli.
5. Crea un GameObject `Babysitter` con un `BabysitterController` e imposta `holdPoint`.
6. Aggiungi una Canvas con un `Text` e attach `DebugUI` per informazioni base.

Note sul formato dei modelli:
- Per importare `.glb` / `.gltf` in Unity consigliato usare il package `com.unity.formats.gltf` (GLTFUtility) o il plugin "UnityGLTF".
- In alternativa, converti i `.glb` in `.fbx` con strumenti esterni e importa gli FBX.

Prossimi passi: importa i modelli in `Assets/Models/`, crea i prefab e aggiungili al `ModelSpawner` per test visivi e di animazione.