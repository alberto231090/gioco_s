# Licenze e link per candidate FBX (da verificare e scaricare)

Nota: ogni asset va verificato per la licenza esatta prima di scaricare e includere nel repository. Solo asset con licenza CC0/CC BY o con permesso esplicito di ridistribuzione saranno copiati nella cartella `Assets/Models`.

1) Mixamo — Character pack (generic child/adult characters)
- Fonte: https://www.mixamo.com/
- Tipo: personaggi riggati (bambini/adulti)
- Licenza: uso tramite Adobe (verificare redistribuzione)
- Note: ottime animazioni compatibili con Unity; spesso usato per prototipi.
---

# Asset importati (stato: in parte manuale)

- Kenney: verificare pacchetto su sito e scaricarlo manualmente (link in `docs/DOWNLOAD_INSTRUCTIONS.md`)
- Sketchfab: due modelli CC0 sono stati identificati; richiedono download manuale via pulsante "Download" (FBX).2) Sketchfab — "Downloadable" humanoid characters (filter)
- Fonte: https://sketchfab.com/search?features=downloadable&q=child
- Tipo: vari (child, adult)
- Licenza: variegata (CC0, CC BY, Custom) — verificare per ogni asset
- Note: alcuni modelli sono riggati e scaricabili in FBX.

3) Unity Asset Store — Free humanoid characters
- Fonte: https://assetstore.unity.com/
- Tipo: Ethan / free humanoid packs
- Licenza: Unity Asset Store EULA (verificare redistribuzione)
- Note: comodi per prototipazione on-platform.

4) Free3D — "Child" / family models
- Fonte: https://free3d.com/
- Tipo: modelli 3D gratuiti
- Licenza: variegata — controllare attribuzioni e limitazioni

5) OpenGameArt — modelli e animazioni
- Fonte: https://opengameart.org/
- Tipo: props e personaggi (spesso low-poly)
- Licenza: CC0, CC BY o simili sicuramente riutilizzabili

6) Kenney — props (mobili, giocattoli)
- Fonte: https://kenney.nl/assets
- Tipo: divano, letto, giocattoli, tappeti
- Licenza: Kenney Public Domain (gratis per uso commerciale, spesso CC0)

7) Mixamo Animation Packs (standalone) — animazioni compatibili
- Fonte: https://www.mixamo.com/
- Tipo: idle/walk/pickup/sit/cry animations
- Licenza: verif. (uso con personaggi Mixamo)

8) Sketchfab — "Kid character free" (esempi)
- Esempio: https://sketchfab.com/3d-models/child-0a3f... (placeholder - verificare link)
- Nota: cercare tag "downloadable" e "rigged"

9) Turbosquid / Free3D — props e scene
- Fonte: https://www.turbosquid.com/ e https://free3d.com/
- Tipo: seggiolino auto, cestino pannolini, mobili

10) Mixamo-compatible community models (GitHub / CC0)
- Fonte: ricerca GitHub / CC0 3D models
- Tipo: personaggi con rig umanoide

---

# Asset scaricati automaticamente (Khronos glTF-Sample-Models)
- `RiggedSimple.glb` — https://github.com/KhronosGroup/glTF-Sample-Models/tree/main/2.0/RiggedSimple — License: **CC BY 4.0** — Uso OK (attribution required)
- `RiggedFigure.glb` — https://github.com/KhronosGroup/glTF-Sample-Models/tree/main/2.0/RiggedFigure — License: **CC BY 4.0**
- `CesiumMan.glb` — https://github.com/KhronosGroup/glTF-Sample-Models/tree/main/2.0/CesiumMan — License: **CC BY 4.0**
- `GlamVelvetSofa.glb` — https://github.com/KhronosGroup/glTF-Sample-Models/tree/main/2.0/GlamVelvetSofa — License: **CC BY 4.0**
- `BoomBox.glb` — https://github.com/KhronosGroup/glTF-Sample-Models/tree/main/2.0/BoomBox — License: **CC BY 4.0**
- `SheenChair.glb` — https://github.com/KhronosGroup/glTF-Sample-Models/tree/main/2.0/SheenChair — License: **CC BY 4.0**
- `FlightHelmet.gltf` — https://github.com/KhronosGroup/glTF-Sample-Models/tree/main/2.0/FlightHelmet — License: **CC BY 4.0**

Passaggi successivi suggeriti:
- Verificare licenze dettagliate e prendere screenshot/URL finali (fatto per i modelli scaricati)
- Importare i modelli in una scena di prova Unity e testare animazioni/scale/materiali
- Aggiornare `docs/LICENSES.md` con le checksum e le istruzioni di attribuzione

Se vuoi, procedo ora a importare questi modelli nella scena prototipo Unity (creo una scena di prova con camera, luce e prefab base).