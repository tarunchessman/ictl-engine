===================================================================
 Ireland Chess Technology Ltd. — Cloud Stockfish 18 Setup Guide
===================================================================

Thank you for subscribing to ICTL Cloud Stockfish 18!
Follow these simple steps to install and start analyzing in ChessBase or Fritz.

-------------------------------------------------------------------
STEP 1: Extract the Package
-------------------------------------------------------------------
1. Extract the entire ZIP folder to a permanent location on your PC
   (e.g., C:\ICTL_CloudEngine\).
2. Confirm that all six files are present in that folder:
   - ICTL_CloudEngine.exe
   - plink.exe
   - credentials.txt
   - README.txt
   - AUTHORS.txt
   - LICENSE.txt

* Note: Do NOT rename or delete credentials.txt. It contains your 
  pre-configured login credentials.

-------------------------------------------------------------------
STEP 2: Add Engine to ChessBase / Fritz
-------------------------------------------------------------------
1. Open ChessBase (or Fritz / ChessGUI).
2. In the top menu, go to:
   Engine -> Create UCI Engine (or press Ctrl + Alt + U).
3. Click "Browse..." and select:
   C:\ICTL_CloudEngine\ICTL_CloudEngine.exe (Wait for few seconds till you see the name of the engine)
4. Click "OK" to finish setup.

-------------------------------------------------------------------
STEP 3: Check Server Availability & Analyze
-------------------------------------------------------------------
1. Before connecting, open your browser and check the server status:
   https://cloudengine.ictl.ie
2. Status Indicators:
   - GREEN LIGHT (ENGINE AVAILABLE): Server is free. Ready to connect.
   - RED LIGHT (ENGINE BUSY): Session active. A live timer shows remaining 
     time (max 60 minutes per session).
   - ORANGE LIGHT (GRACE PERIOD): A 1-minute priority window opens when a 
     session ends. Other subscribers get first right of refusal; the 
     previous user must wait 1 minute before reconnecting.
3. Open any game board in ChessBase and press F3 (or "Add Analysis Engine").
4. Select "ICTL Cloud Stockfish 18" to stream analysis instantly.

-------------------------------------------------------------------
ENGINE PERFORMANCE & KEY FEATURES
-------------------------------------------------------------------
- Blazing Speed: High-throughput analysis generating ~10+ Million Nodes 
  Per Second (NPS) for rapid depth progression and instant blunder detection.
- Neural Net Evaluation: Powered by Stockfish 18 NNUE dual-network 
  architecture for Grandmaster-grade position accuracy.
- Massive Hash Memory: 32 GB (32,768 MB) dedicated hash memory allocation 
  to retain deep endgame variations and complex positional transpositions.
- Dedicated Server Processing: 12 high-frequency CPU cores running on 
  dedicated infrastructure in Germany.
- Zero Local Load: 100% cloud-offloaded computation. Keeps your PC cool, 
  silent, and battery-friendly during heavy analysis sessions.

-------------------------------------------------------------------
USAGE & SESSION RULES
-------------------------------------------------------------------
- Auto-Release: Closing ChessBase or stopping engine analysis releases 
  the server session immediately for other subscribers.
- 60-Min Session Cap: Each active session has a hard 60-minute limit 
  to ensure equitable server access across all users.
- 1-Min Fair Access Grace Period: After your session ends, a 1-minute 
  Orange Light cooldown applies to your account to give other subscribers 
  a chance to claim the engine. If unused after 1 minute, the light turns 
  Green and you may reconnect freely.

-------------------------------------------------------------------
SUPPORT
-------------------------------------------------------------------
Live Status: https://cloudengine.ictl.ie
Email: info@ictl.ie
Ireland Chess Technology Ltd.
===================================================================