
# Aurora Quest

_A lean Unity demo that showcases a dynamic, interactive game prototype with advanced shader effects, environmental interactions, and intuitive player controls._

## Overview

Aurora Quest is a minimal yet polished demo built in Unity that demonstrates:
- **Dynamic Aurora Effects:** Custom shader-based visuals that simulate a moving aurora in the sky.
- **Interactive Gameplay:** A controllable player object that collects orbs and interacts with puzzle elements (doors) to progress.
- **Environmental Depth:** A terrain with proper colliders, additional environmental objects (trees, rocks), and a realistic skybox featuring clouds and a blue sky.
- **Technical Excellence:** Clean, modular code with clear physics integration and responsive camera controls.

This project was developed to showcase creative level design, shader programming, and rapid prototyping—skills that are valuable for roles in game technology and creative software development.

## Features

- **Player Controller:** A Capsule-based player with simple movement (WASD) and jumping using Rigidbody physics.
- **Aurora Shader:** A custom shader (written in ShaderLab/HLSL) that creates an animated aurora effect.
- **Collectibles & Puzzle Mechanics:** Interactive spheres (collectibles) that, when gathered, trigger a door (barrier) to open.
- **Dynamic Environment:** Utilizes a Terrain object with colliders to simulate realistic ground, complemented by additional low-poly models for trees and rocks.
- **Camera Follow:** A smooth camera follow script that keeps the player centered and ensures an immersive view.
- **Skybox with Clouds:** A custom skybox material featuring cloud textures to enhance the overall ambiance.

## Getting Started

### Prerequisites

- **Unity Hub:** Download and install from [Unity Download Page](https://unity.com/download).
- **Unity Editor:** Use the latest LTS version (e.g., Unity 2023 LTS) with modules for your target platforms.
- **Visual Studio Code:** Recommended for scripting; install with the C# extension (or use Visual Studio Community).

### Setup Instructions

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/yourusername/AuroraQuest.git
   cd AuroraQuest