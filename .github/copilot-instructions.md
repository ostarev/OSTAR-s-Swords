# Copilot Instructions

## General Guidelines
- First general instruction
- Second general instruction

## Code Style
- Use specific formatting rules
- Follow naming conventions

## Project-Specific Rules
- The project's buff class `LesserMeleePower` is declared in the namespace `UniverseOfSwordsModOld.Buffs` (file `Content/Buffs/LesserMeleeBuff/LesserMeleePower.cs`).
- When applying damage in tModLoader, use `ModifyHitNPC` with `ref damage` or `target.StrikeNPC` in `OnHitNPC`. Handle multiplayer scenarios by checking `Main.netMode` for server-side operations.