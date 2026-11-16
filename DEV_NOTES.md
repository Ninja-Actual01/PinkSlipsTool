# Pink Slips Tool — Dev Notes

A Windows desktop tool (WPF / .NET) for **EA SPORTS College Football 27** dynasty leagues. It provides a star/perk system and direct dynasty save-file editing (roster moves, dev traits, injuries, eligibility, position changes, etc.).

## For users

- **Platform:** Windows 10/11 (x64).
- **Run:** Use the latest release build (`PinkSlipsTool.exe`). No separate .NET runtime install is required for self-contained release builds.
- **Saves:** CFB27 dynasty saves are typically in `Documents\EA SPORTS College Football 27\saves\`.
- **Important workflow:**
  1. Play the week in-game and save your dynasty.
  2. Back out of dynasty mode so the game is not holding the save open.
  3. Load the save in Pink Slips Tool (a timestamped `.bak` backup is created on load).
  4. Make edits/apply perks, then save.
  5. Load the updated save in-game.
- **Safety:** Keep backups. Use **Restore Backup** if you need to roll back. Do not edit a save while the game has it open.

See [README.md](README.md) for feature details, perk effects, and known limitations.

## For contributors / developers

### Prerequisites
- Windows with **.NET SDK 8+** (project targets a modern .NET/WPF toolchain; install the SDK version required by `PinkSlipsTool.csproj` if different).
- Git.

### Build
From the project root:

```powershell
dotnet restore
dotnet build -c Release
```

To produce a self-contained single-file publish (similar to releases):

```powershell
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o .\publish
```

### Project structure (high level)
- `Models/` — dynasty save parsing, codecs, schemas, and edit logic
- `ViewModels/` — app state and commands
- `Views/` — WPF UI/popups
- `Converters/`, `Styles/`, `Images/` — UI resources
- `Tools/` — utilities (e.g. schema/debug helpers)

### Notes
- Save edits are applied at the bit/record level and rewritten with correct compression/checksum/length for the game format.
- Roster changes must respect in-game roster constraints (e.g. 85-player cap); prefer swap/cut flows where required.
- Honor-system perks are not written to the save file; file-applied perks are.
- When changing save-format logic, validate against backups and in-game reload behavior before publishing a release.
