# ***atlas-unity-virtual-reality-two***



# [VR Accessibility Project Documentation](https://github.com/Bmontezuma/atlas-unity-virtual-reality-two/tree/main/accessibility)
![Pic](https://imgur.com/0rdiNP0.jpg)

## Table of Contents
1. [Project Overview](#project-overview)
2. [Features and Implementation](#features-and-implementation)
   - [Virtual Magnifying Glass](#virtual-magnifying-glass)
   - [Motion Sickness Mitigation](#motion-sickness-mitigation)
3. [Settings and Accessibility Options](#settings-and-accessibility-options)
4. [User Testing](#user-testing)
   - [Hypothesis](#hypothesis)
   - [Experimentation Method](#experimentation-method)
   - [Testing Logs](#testing-logs)
   - [Conclusions and Findings](#conclusions-and-findings)
5. [Documentation of Design Choices and Feedback Incorporation](#documentation-of-design-choices-and-feedback-incorporation)
6. [Final Testing and Compilation](#final-testing-and-compilation)

---

## Project Overview

This project focuses on creating a VR environment with accessibility features that improve usability for users with varying needs. Key elements include a virtual magnifying glass for enhanced readability, motion sickness reduction options, and thorough accessibility customization to ensure a comfortable experience for all users.

---

## Features and Implementation

### Virtual Magnifying Glass

#### Objective
To provide a movable, XR-interactable magnifying glass that allows users to zoom into text, objects, and environmental elements for better visibility.

#### Implementation Steps
1. **Create a Magnifying Glass Object**:
   - **Design**: Construct a circular or spherical object to serve as the lens of the magnifying glass.
   - **XR Interactable Setup**: Attach an `XR Grab Interactable` component to enable the user to grab and move the magnifying glass without physics or gravity effects.

2. **Camera and Shader Setup**:
   - **Secondary Camera**: Set up a secondary camera specifically for magnified rendering. This camera should be positioned in alignment with the magnifying glass lens, capturing a close-up view of the surroundings.
   - **Render Texture**: Link the camera output to a render texture. Apply this texture to the magnifying glass lens or sphere.
   - **Custom Shader (Optional)**: To enhance the effect, create a shader to simulate lens distortion or rounded edges, mimicking real magnification.

3. **User Interaction**:
   - Ensure the magnifying glass is easily activated in the VR environment and remains in the user's control until manually placed or deselected.
   - **Tooltip and Instructions**: Provide a clear guide within the VR settings on how to pick up, activate, and use the magnifying glass for optimal results.

---

### Motion Sickness Mitigation

#### Objective
To minimize VR motion sickness by allowing users to adjust movement and rotational settings, providing a smoother, customizable VR experience.

#### Implementation Steps
1. **Adjustable Movement Speed**:
   - Add a slider in the settings to allow users to select their preferred movement speed. Slower speeds can help reduce motion sickness for sensitive users.

2. **Field of View (FOV) Restriction**:
   - **Vignetting Effect**: Implement a subtle vignette effect around the user’s field of view, which reduces peripheral vision during movement, helping to minimize disorientation.
   - Use an image mask or a vignette shader that adjusts based on user movement to smoothly darken the edges of the view.

3. **Rotation Options**:
   - **Smooth vs. Snap Rotation**: Add a toggle between smooth rotation (continuous) and snap rotation (discrete 45° or 90° increments).
   - Use Unity’s `XR Interaction Toolkit` or similar to implement adjustable rotation, ensuring snap rotation minimizes nausea.

4. **Locomotion Options**:
   - **Teleportation**: Allow users to move around by teleporting to chosen locations.
   - **Smooth Locomotion**: Provide an option for continuous movement for users who are comfortable with it.
   - **Settings Menu**: Integrate these options into the settings menu for easy access.

---

## Settings and Accessibility Options

The Settings menu should include the following adjustable accessibility options for users:

1. **Virtual Magnifying Glass**:
   - Instructions on how to grab, position, and use the magnifying glass.
   - An option to adjust the zoom level for magnified content.

2. **Motion Sickness Mitigation**:
   - Movement Speed: Slider for speed adjustment.
   - Field of View: Toggle for enabling/disabling the vignette effect.
   - Rotation Settings: Toggle between smooth and snap rotation.
   - Locomotion Options: Select between teleportation and smooth locomotion.

---

## User Testing

### Hypothesis
**Hypothesis**: By integrating a virtual magnifying glass and customizable movement/rotation settings, users with visual impairments and motion sensitivity will experience an improved VR environment with minimal discomfort and enhanced readability.

### Experimentation Method
1. **Test Groups**:
   - Users with motion sensitivity
   - Users with visual impairments
   - General users for baseline comparison

2. **Testing Phases**:
   - **Phase 1**: Initial setup and usability of the magnifying glass.
   - **Phase 2**: Usability of motion sickness mitigation features, with participants encouraged to adjust settings.
   - **Phase 3**: Combined use of magnification and motion mitigation features in real gameplay scenarios.

3. **Feedback Collection**:
   - Use structured surveys and observation logs to record user experiences.
   - Gather qualitative data on ease of use, comfort level, and any nausea or disorientation experienced.

### Testing Logs

| Test Date | Participant | Phase | Feedback Summary                                                                                         | Adjustments Made                                                                                     |
|-----------|-------------|-------|----------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------|
| Oct 25    | User A      | 1     | Found magnifying glass easy to use but suggested greater zoom adjustability.                             | Increased zoom range on magnifying glass.                                                            |
| Oct 26    | User B      | 2     | Motion sickness reduced with snap rotation and vignette effect; smooth movement caused mild discomfort. | Set snap rotation as default; reduced vignette intensity for less intrusive visuals.                 |
| Oct 27    | User C      | 3     | Magnifying glass aided text reading significantly; teleportation preferred over smooth locomotion.      | No major changes; teleportation set as default for initial testing.                                  |
| Oct 28    | User D      | 3     | Required larger buttons for magnified UI; vignette effect felt disorienting when moving slowly.         | Increased UI button size; made vignette effect adjustable in settings for intensity.                 |

### Conclusions and Findings

**Key Findings**:
- **Virtual Magnifying Glass**: Highly effective for text readability; recommended increasing the maximum zoom level.
- **Motion Sickness Settings**: Snap rotation and teleportation significantly improved comfort for most users.
- **Vignette Effect**: Useful for reducing motion sensitivity but required adjustability to suit different users’ preferences.

---

## Documentation of Design Choices and Feedback Incorporation

1. **Magnifying Glass**:
   - **Choice**: Render texture and shader for realistic magnification.
   - **Feedback Incorporation**: Increased zoom levels and made instructions on usage clearer based on testing feedback.

2. **Motion Sickness Features**:
   - **Choice**: Snap rotation and teleportation prioritized as default for new users to reduce motion discomfort.
   - **Feedback Incorporation**: Customizable vignette intensity and teleportation as default were added following user input.

3. **Settings Menu**:
   - **Choice**: Simple and intuitive layout with slider and toggle options for easy customization.
   - **Feedback Incorporation**: Enlarged UI elements for improved interaction, particularly for visually impaired users.

---

## Final Testing and Compilation

### Compilation
After incorporating feedback, compile the final VR environment, integrating the following accessibility features:
- **Virtual Magnifying Glass** with enhanced zoom and interaction instructions.
- **Motion Sickness Mitigation** settings, including adjustable speed, rotation options, and vignette effect.
- **Customized Settings Menu** with clearly marked options for ease of access and visibility.

### Final Testing
Conduct a final round of testing with users, confirming the functionality and comfort of each feature. Verify smooth performance and that all adjustments have resolved previous feedback points.

---

This documentation provides a complete overview of the VR accessibility project, detailing the feature implementations, testing processes, and the thoughtful incorporation of user feedback to ensure a highly accessible VR experience.

# [Physics-Based Interactions in VR](https://github.com/Bmontezuma/atlas-unity-virtual-reality-two/tree/main/physics-interaction)

![pic](https://i.imgur.com/71Pk9ad.jpg)

# Final VR Application Build Documentation

## Table of Contents
1. [Project Overview](#project-overview)
2. [Integrated Features and Interactions](#integrated-features-and-interactions)
   - [Bouncy Ball, Heavy Crate, and Feather](#bouncy-ball-heavy-crate-and-feather)
   - [Multi-Point Grabbing System](#multi-point-grabbing-system)
   - [Realistic Throwing Mechanic](#realistic-throwing-mechanic)
   - [Balancing Beam Challenge](#balancing-beam-challenge)
   - [Telekinetic Force Grab](#telekinetic-force-grab)
   - [Lever Interaction](#lever-interaction)
   - [Domino Chain Reaction](#domino-chain-reaction)
3. [Final Testing](#final-testing)
4. [User Feedback and Adjustments](#user-feedback-and-adjustments)
5. [Optimization Strategies](#optimization-strategies)
6. [Conclusions and Learnings](#conclusions-and-learnings)

---

## Project Overview

This final build is a culmination of physics-based interactions implemented in VR, designed to create a realistic, engaging, and accessible VR experience. Each element of the scene has been carefully optimized for physics behavior, user interaction, and performance, resulting in a robust VR application.

---

## Integrated Features and Interactions

### Bouncy Ball, Heavy Crate, and Feather

**Overview**: This interaction showcases three objects with distinct physics properties— a bouncy ball, a heavy crate, and a feather. Each object demonstrates unique behaviors based on mass, friction, bounce, and drag.

- **Bouncy Ball**: Low mass and high bounce, simulating a light, resilient object.
- **Heavy Crate**: High mass and moderate friction, providing a sluggish response when pushed.
- **Feather**: Low mass and high drag, allowing it to flutter gently and simulate air resistance.

**Testing Results**:
Each object reacted realistically in response to VR interactions, including picking, dropping, and collisions. User feedback confirmed that the distinctions between each object’s properties were clearly felt.

---

### Multi-Point Grabbing System

**Overview**: A sophisticated two-handed grabbing mechanic implemented for a sword, enabling users to control the sword with both hands for precise, realistic movements.

- **Primary Grab Points**: Upper hilt, lower hilt, pommel, and blade.
- **Physics Setup**: Utilized FixedJoint and HingeJoint components for realistic connection points, with constraints to limit excessive bending or twisting.

**Testing Results**:
The sword offered both one-handed and two-handed use, allowing fine control for precise manipulation. The grab transitions were smooth, and constraints successfully prevented unnatural movements.

---

### Realistic Throwing Mechanic

**Overview**: A dynamic throwing system was implemented using a bowling ball, simulating a realistic weight and release motion for VR users.

- **Mechanics**: The VR controller’s velocity at release was used to calculate throwing force.
- **Physics Adjustments**: Factored in mass, size, and drag to determine speed, direction, and arc of the throw.

**Testing Results**:
The bowling ball’s trajectory accurately reflected real-life bowling physics, responding to variations in force and direction. This interaction felt intuitive, particularly with the visual release cues and haptic feedback.

---

### Balancing Beam Challenge

**Overview**: A physics-based stacking and balancing game where users carefully place objects on a balancing beam to test precision and patience.

- **Objects**: Spheres, cubes, cones, each with distinct weights and physics materials.
- **Platform**: A narrow, rectangular beam that tilts based on weight distribution.

**Testing Results**:
The beam and objects performed reliably in VR, with realistic responses to shifts in weight and movement. Sound effects for placement and wobbling added satisfying feedback, enhancing immersion.

---

### Telekinetic Force Grab

**Overview**: This feature allows users to grab and manipulate objects from a distance, using a laser pointer for selection and force mechanics for interaction.

- **Mechanics**: The force applied increases with the duration of the button hold, creating a progressive, realistic movement.
- **Selection Feedback**: Objects within selection range are highlighted, and a visual laser pointer aids precision.

**Testing Results**:
The telekinetic grab felt intuitive, and the object highlighting provided clear visual feedback. The laser pointer and gradual force application contributed to a smooth, immersive experience.

---

### Lever Interaction

**Overview**: A satisfying lever mechanism that incorporates realistic physics and haptic feedback, using hinge joints for controlled movement.

- **Design**: The lever features an ancient stone aesthetic, with physics tuned to provide a slight resistance during interaction.
- **Feedback**: Visual rotation indicators, sound effects, and subtle vibrations enhance user satisfaction.

**Testing Results**:
The lever’s resistance and feedback were effective, creating an engaging and tactile experience. Users found the lever intuitive to use, with the haptics and sound adding to the realism.

---

### Domino Chain Reaction

**Overview**: A visually impressive domino effect with multiple ramps, turns, and elevation changes to enhance engagement.

- **Setup**: Consisted of aligned cubes representing dominoes, spaced and shaped for a smooth chain reaction.
- **Trigger**: The first domino is activated by a button press, initiating the sequence.

**Testing Results**:
The chain reaction worked seamlessly, with reliable physics interactions and minimal friction to prevent stalling. The carefully spaced ramps and turns made for an engaging visual spectacle.

---

## Final Testing

### Testing Procedure
Each interaction was tested individually and collectively within the final scene to ensure that all elements worked seamlessly together without any performance degradation.

### Key Testing Areas
1. **Physics Accuracy**: Checked for realistic physics responses in each interaction.
2. **Responsiveness**: Ensured minimal lag or delay in reactions, with each interaction responding instantly to user inputs.
3. **User Experience**: Observed for fluidity and ease of use, focusing on the intuitiveness of each interaction.

### Summary of Results
All interactions performed as expected. Adjustments were made to fine-tune the responsiveness of the telekinetic grab and to optimize the domino physics. Feedback confirmed that each interaction felt natural and engaging.

---

## User Feedback and Adjustments

### Feedback Collection
Three users with varying VR experience tested the interactions. Observation questions focused on realism, responsiveness, and areas for improvement. Key feedback points included:

- **Telekinetic Grab**: Users appreciated the smoothness but suggested a clearer highlight on selected objects.
- **Domino Reaction**: Users found it satisfying but recommended slightly faster domino fall speeds.
- **Lever Interaction**: Haptic feedback was praised; users suggested adding a visual indicator for rotation limits.

### Adjustments Made
1. **Telekinetic Grab**: Enhanced object highlighting with a soft glow to improve visibility.
2. **Domino Speed**: Adjusted domino spacing to increase fall speed slightly.
3. **Lever Indicator**: Added a subtle rotation guide to help users gauge movement limits.

---

## Optimization Strategies

1. **Physics Simplification**: Reduced the number of active rigidbody interactions by using simplified colliders for non-essential objects.
2. **LOD (Level of Detail)**: Implemented LOD for distant objects to reduce rendering costs, especially during the domino chain reaction.
3. **Batching Physics Calculations**: Grouped similar objects (like dominoes) for collective physics updates, reducing frame-by-frame calculations.
4. **Framerate Profiling**: Used Unity’s Profiler to identify and address bottlenecks, ensuring the scene maintained a consistent frame rate.

### Performance Improvements
These optimizations resulted in smoother physics calculations and improved overall scene performance, particularly during intensive interactions like the domino effect and telekinetic grabs.

---

## Conclusions and Learnings

1. **Physics Development in VR**: Implementing realistic physics in VR requires careful attention to mass, drag, friction, and interaction feedback to maintain immersion.
2. **User Feedback Integration**: Observing users directly provided invaluable insights into interaction intuitiveness and satisfaction, highlighting small adjustments that significantly improved the experience.
3. **Optimization for VR**: Physics-based VR applications need to balance realism with performance, particularly for complex interactions. The use of simplified colliders, LODs, and batch processing proved essential for maintaining smooth, realistic interactions.

### Final Remarks
This VR application serves as a comprehensive demonstration of physics-based interactions in VR, successfully integrating multiple physics elements into a cohesive, immersive experience. Each feature functions optimally, reflecting the careful consideration of both user experience and technical performance.


