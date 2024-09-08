# IOStorePak - Packager for the UE I/O Store Format

The purpose of this tool is to allow cooked assets to be packaged in the I/O Store format. This means you can extract assets from a game, edit them in your preferred asset editor, and then package them for release without needing to worry about reverse engineering anything.

The Nexus Mods page for this tool is [here](https://www.nexusmods.com/gothamknights/mods/422).

The old/previous archived repo for this tool is [here](https://github.com/amMattGIT/iostorepak).

## Requirements

- A compiled build of Unreal Engine (4.25+ for Gotham Knights)
- An Unreal project (.uproject)

## Documentation

The tool is an executable file called `IOStorePak.exe`.

A configuration file called `config.json` is used by the tool to store user settings, such as the paths to your Unreal Engine build and `.uproject` file, as well as your personalization choices.

The tool will automatically save your choices in the `config.json` after you adjust them through the GUI (upon closing the tool).

You can select either specific individual assets or an entire folder of assets.

### Paths

#### Unreal Engine Directory

The path to the root of your Unreal Engine build, e.g., `T:\Tools\UnrealEngine\UnrealEngine-4.25-plus`.

#### Unreal Project File

The path to your `.uproject` file, e.g., `T:\Modding\Gotham Knights\Kitchen\Mercury\Mercury.uproject`.

> **Note:** Project name doesn't matter, and neither do the contents of your project.

#### Select Assets to Package

Select which assets should be packaged. Sub-options available:

- **Select Files:** Select individual files (`.uasset` and `.uexp`).
- **Select Folder:** Select an entire folder. Subfolders and assets will be included.

> **Note:** The location of your assets does not matter, but the directory structure must match the game, e.g., `....\Content\Character\Recipes\Player\Robin\Casual`.

### Regular Settings

#### Chunk Number

Specify the chunk ID/number your packaged files will use.

#### Clean Cooked Folder Before Packaging

Will clean out the `Saved\Cooked` folder in your project, ensuring only the assets you select will be packaged.

#### Open Output Folder After Packaging

Will open the folder containing your packaged files after packaging completes.

#### Dark Mode

Toggles Dark Mode (lol).

#### Package Assets

Starts packaging the assets. The Unreal Automation tool is used for this, meaning a window for the automation tool will open and proceed with the packaging.

> **Note:** The automation tool window will automatically close once done. The IOStorePak tool will inform you with a pop-up.

### Advanced Settings

#### Debug Mode

Creates a logfile called `IOStorePak.log` in the root of the application. The log includes entries for each action performed by the tool. Also sets the UAT shell window to stay open, allowing the user to inspect the UAT process.

#### Compress

Compresses the packaged files, resulting in a smaller file size.

#### Clean Output Folder Before Packaging

Will clean out the `Saved\StagedBuild` folder in your project, deleting previous packages.

> **Note:** If you use this option, make sure nothing important (i.e. your pak files) is in the StagedBuild folder.

## Additional Info

Big credit to [@Phnx](https://next.nexusmods.com/profile/Phnx) for figuring out the automation tool could skip the cooking process for I/O store packaging. That's the whole reason I decided to create this tool.

## If You'd Like to Support Me

My Patreon is [here](https://www.patreon.com/amMatt).
