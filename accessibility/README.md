# ***Accessibility Features in VR***

![Image](https://imgur.com/0rdiNP0.jpg)

# VR Accessibility Project Documentation

## Table of Contents
1. [Project Overview](#project-overview)
2. [Tasks and Implementation Details](#tasks-and-implementation-details)
   - [Task 0: Implement Gaze Controls](#task-0-implement-gaze-controls)
   - [Task 1: Design Audio Cues for Visual Impairments](#task-1-design-audio-cues-for-visual-impairments)
   - [Task 2: Contrast and Text Size Settings](#task-2-contrast-and-text-size-settings)
   - [Task 3: Integrate a Magnifying Glass Feature](#task-3-integrate-a-magnifying-glass-feature)
   - [Task 4: Motion Sickness Adjustments](#task-4-motion-sickness-adjustments)
   - [Task 5: Accessibility Testing and User Feedback](#task-5-accessibility-testing-and-user-feedback)
   - [Task 6: Comprehensive Documentation](#task-6-comprehensive-documentation)
   - [Task 7: Final Build and Testing](#task-7-final-build-and-testing)
3. [Optimization and Performance Improvements](#optimization-and-performance-improvements)
4. [User Feedback and Conclusions](#user-feedback-and-conclusions)
5. [References and Resources](#references-and-resources)

---

## Project Overview

This project integrates comprehensive accessibility features within a VR application to cater to users with various needs, including visual and motion impairments. The following tasks were completed to ensure a user-friendly, accessible experience in VR, following guidelines for intuitive design, audio feedback, visual adjustments, and interaction methods.

**Repository**: [GitHub repository: atlas-unity-virtual-reality](https://github.com/yourusername/atlas-unity-virtual-reality)  
**Directory**: `accessibility`

---

## Tasks and Implementation Details

### Task 0: Implement Gaze Controls
**Objective**: Develop a gaze-based control system allowing users to interact without traditional hand controllers, creating a reusable main menu for future VR applications.

**Features**:
- **Gaze-Based Menu**: Users interact with UI elements (e.g., “Launch Game”, “Quit Game”, “Settings”, “Options”) through sustained gaze, with adjustable selection duration.
- **Slider for Gaze Duration**: Users can modify gaze duration settings in the Options menu for tailored control.
- **Visual Feedback**: A circular progress indicator shows selection progress, and a flash indicates completion.

**Implementation**:
- Used Unity’s XR Interaction Toolkit for gaze detection and UI integration.
- Created a “GazeButton” script with visual cues for starting, progressing, and completing selections.

---

### Task 1: Design Audio Cues for Visual Impairments
**Objective**: Add audio and haptic feedback to support visually impaired users, providing cues for interaction progress and completion.

**Audio Cues**:
- **Starting Selection**: A soft “click” sound when initiating a gaze selection.
- **During Selection**: Progressive ticking or tone to signal ongoing selection.
- **Completion**: A bell sound indicates successful selection.
- **Gaze Hints**: Light audio hints when gazing past interactive elements.

**Implementation**:
- Configured audio sources for each UI element to trigger sounds based on user interaction.
- Added a “Gaze Hints” toggle in the Options menu for users to enable or disable hint sounds.
- Included volume settings for audio cues to ensure customizable feedback.

---

### Task 2: Contrast and Text Size Settings
**Objective**: Implement adjustable settings for window size, color contrast, and text size to enhance readability for users with visual impairments.

**Settings**:
- **UI Window Size**: Added scaling options for horizontal and vertical resizing.
- **Text Size**: Included a range slider for text size adjustment, scaling dynamically with window size.
- **High Contrast Mode**: Designed color palettes for maximum visibility, including options for Protanopia, Deuteranopia, and Tritanopia.

**High Contrast Colors**:
- **Standard**: Black background, white title text, light grey subtitle text, and dark grey standard buttons.
- **Protanopia/Deuteranopia**: Dark blue background with yellow highlights.
- **Tritanopia**: Dark grey background with white highlights.

**Implementation**:
- Created a “ContrastSettings” script that applies chosen color palettes.
- Adjusted font sizes and UI component layouts to support scalable resizing.

---

### Task 3: Integrate a Magnifying Glass Feature
**Objective**: Design a virtual magnifying glass allowing users to zoom into text, objects, and the environment for enhanced readability.

**Features**:
- **XR Interactable**: Set up a magnifying glass as an XR Grab Interactable object, allowing users to grab and move it freely.
- **Zoom Effect**: Used a secondary camera with a render texture applied to a spherical lens to simulate magnification.
- **Ease of Use**: The magnifying glass activates in close proximity to UI text and adjusts zoom dynamically.

**Implementation**:
- Developed a custom shader for the lens effect to replicate realistic magnification.
- Implemented proximity detection for activating the magnifying effect on targeted elements.

---

### Task 4: Motion Sickness Adjustments
**Objective**: Implement settings to reduce motion sickness, focusing on movement speed, field of view (FOV), and rotational adjustments.

**Settings**:
- **Vignetting**: Added a vignette effect to reduce peripheral vision during movement.
- **Rotation Options**: Users can toggle between smooth and snap rotation.
- **Locomotion Choices**: Provided options for teleportation and smooth locomotion.

**Implementation**:
- Created a settings panel with clear instructions on accessing motion sickness adjustments.
- Used Unity’s Post-Processing Stack for the vignette effect and XR Interaction Toolkit for rotation and locomotion settings.

---

### Task 5: Accessibility Testing and User Feedback
**Objective**: Conduct thorough testing with a diverse group of users to gather feedback and identify areas for improvement.

**Testing Methodology**:
- **Hypothesis**: The implemented accessibility features improve user experience by providing necessary support for visual and motion impairments.
- **User Groups**: Engaged users with varying VR experience, including those with visual impairments and motion sensitivity.
- **Feedback Questions**: Asked if interactions felt realistic, responsive, and what could be improved.

**Findings**:
- Users with motion sensitivity preferred teleportation and snap rotation.
- Feedback on color contrast and text size was positive; users appreciated the distinct options.

**Adjustments Made**:
- Increased the maximum zoom level on the magnifying glass based on user feedback.
- Fine-tuned snap rotation angles and vignette intensity for smoother transitions.

---

### Task 6: Comprehensive Documentation
**Objective**: Provide detailed documentation for each feature, covering implementation steps, design choices, and feedback incorporation.

**Documentation Highlights**:
- Explained the process of designing gaze controls, audio cues, visual adjustments, and the magnifying glass feature.
- Detailed optimization techniques for smoother interactions.
- Included insights from user feedback to showcase a user-centered development approach.

---

### Task 7: Final Build and Testing
**Objective**: Compile the VR application, ensuring all features function seamlessly, and conduct final testing to confirm accessibility and user experience.

**Final Testing Areas**:
- **Physics Accuracy**: Ensured realistic responses for interactions with objects.
- **User Experience**: Validated the intuitiveness and responsiveness of each feature.
- **Performance**: Used Unity’s Profiler to optimize frame rate and reduce load on physics calculations.

**Results**:
All features functioned as expected, and user feedback confirmed that the interactions felt natural and immersive.

---

## Optimization and Performance Improvements

1. **Physics Simplification**: Reduced the number of active physics interactions by consolidating similar operations.
2. **LOD (Level of Detail)**: Applied LOD to objects in the VR scene, reducing rendering costs for distant items.
3. **Batching Physics Calculations**: Grouped similar physics operations to decrease frame-by-frame calculations.
4. **Profiling and Refinement**: Used Unity’s Profiler to address specific performance bottlenecks, improving overall efficiency.

---

## User Feedback and Conclusions

### Key Takeaways
- **Gaze-Based Interaction**: Users found the gaze-based menu easy to use, especially with visual and audio feedback.
- **Audio Cues and Haptics**: Enhanced user experience significantly, particularly for those with visual impairments.
- **Adjustable Settings**: The contrast and motion sickness adjustments proved essential for creating a comfortable and accessible VR experience.

### Final Remarks
This VR application exemplifies the importance of accessibility in VR development, providing a user-friendly, immersive experience tailored to a diverse audience. Feedback-driven iterations helped refine the application, ensuring each feature performed optimally for users with varying needs.

---

## References and Resources
- **Unity Documentation**: [Unity Manual](https://docs.unity3d.com/Manual/index.html)
- **XR Interaction Toolkit**: [Unity’s XR Toolkit](https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.0/manual/index.html)
- **Post-Processing Stack**: [Unity Post-Processing](https://docs.unity3d.com/Packages/com.unity.postprocessing@2.3/manual/index.html)
- **Color Contrast Accessibility**: [WebAIM Contrast Checker](https://webaim.org/resources/contrastchecker/)

