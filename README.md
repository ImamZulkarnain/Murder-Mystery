# 🕵️‍♂️ **VR Murder Mystery Game: *Only Murder at the Campus***

## 📝 **Project Overview**

In this VR game, players assume the role of an investigator tasked with solving the murder of Dr. Green, a high-profile researcher. The game involves:

- Navigating through **memory sequences**.
- **Trading information** with the police.
- **Unlocking clues** hidden in the environment.
- **Balancing chemical solutions** to uncover the truth.

The game uses **XR Interaction Toolkit** for VR interactions,  and **Unity’s physics system** for realistic interactions.

---

## 🚀 **Features**

### 1. **Dr. Green's Memory Sequence**

- **Description**: Experience Dr. Green's memories through a sequence of **thought bubbles** that appear in 3D space.
- **Implementation**:
  - **World Space UI** for displaying thought bubbles.
  - **Trigger Colliders** and **Ray Interactions** to activate memories.
  - **Audio Clips** and **Animation Controllers** for delivering information about suspects and their motives.
  

### 2. **Information Trade with Police**

- **Description**: Exchange hidden intel with the police to receive valuable clues.
- **Implementation**:
  - **UI Buttons** for selecting information to trade.
  - **State Machines** for controlling trade interactions.
  - **Event-Driven Programming** to handle information exchanges dynamically.


### 3. **Unlocking Dr. Green's Phone**

- **Description**: Find passcode digits hidden in the courtyard and unlock Dr. Green's phone to reveal a crucial email.
- **Implementation**:
  - **Interactive Adventure Elements** using **XR Grab Interactables** and **Box Colliders**.
  - **Passcode Entry System** with a **Numerical Keypad UI**.
  - **Animation and Audio Feedback** upon unlocking.



### 4. **Balancing the pH Level**

- **Description**: Adjust the pH level of a water sample by pouring acidic and alkaline solutions to match a target level.
- **Implementation**:
  - **Physics-Based Liquid Simulation** for pouring actions.
  - **Dynamic UI Update** for real-time pH display.
  - **Static Flags** to lock interactions once the target pH is achieved.


