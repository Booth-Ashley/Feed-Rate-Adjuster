<a href="#"><img src="https://github.com/user-attachments/assets/ffaddbc2-4e73-4a64-9fdc-fbbecbec25f8" /></a>

# Feed Rate Adjuster

**Feed Rate Adjuster** is a Windows application built using C#. The app automatically adjusts the feed rate in G-code for CNC machines. It allows users to modify the feed rate for G2 and G3 commands based on the value they input (ranging from 1 to 10,000). The adjusted G-code can then be saved into a new file.

## Features

- **Adjust Feed Rate**: Automatically modify the feed rate in your G-code files for G2 and G3 commands.
- **Easy File Selection**: Browse and select the G-code file you want to edit.
- **Input Custom Feed Rate**: Specify a new feed rate between 1 and 10,000.
- **Save Modified File**: After adjustment, save the new G-code file with the modified feed rate.

## Use Case: Improving Cut Quality and Accuracy

In CNC machining, G2 and G3 commands are used for circular movements, either clockwise (G2) or counterclockwise (G3). These movements are critical in many machining operations, especially for precision parts with curved features. However, the default feed rates used for these commands might not always be optimal for achieving the best cut quality and accuracy.

### Why Adjust the Feed Rate for G2 and G3 Movements?

Slowing down the feed rate during circular movements can significantly improve the quality of the cut and the accuracy of the part being machined. Here’s why:

1. **Better Surface Finish**:
   Slower feed rates allow the cutting tool to make smoother passes over the material, reducing the likelihood of tool chatter and vibrations. This results in a finer, more consistent surface finish, which is especially important for parts that need to meet high tolerances or have a polished appearance.

2. **Improved Accuracy**:
   Faster feed rates during circular movements can lead to a loss of precision due to mechanical limitations or inaccuracies in the CNC machine’s response. By reducing the feed rate for G2 and G3 commands, the machine is better able to follow the precise circular path, leading to more accurate part dimensions.

3. **Enhanced Tool Life**:
   Slower feed rates can reduce the wear and tear on the cutting tool, extending its lifespan. This is particularly beneficial for high-cost tools, where optimizing cutting conditions can save money over time and improve overall machining efficiency.

4. **Avoiding Overheating**:
   Cutting at a slower feed rate allows for better heat dissipation during machining. Faster feed rates can lead to increased friction between the tool and material, causing the cutting tool to overheat and potentially damage both the tool and the workpiece. A slower feed rate helps mitigate this risk.

5. **Custom Feed Rate Adjustment**:
   By adjusting the feed rate to match the material being cut and the specific geometry of the part, you can ensure that the CNC machine operates under optimal conditions. This customization helps in balancing speed with precision to achieve the best results for each unique job.

### When to Use the Feed Rate Adjuster

The **Feed Rate Adjuster** application is ideal for machinists who frequently work with G-code and need to fine-tune the feed rates for G2 and G3 movements. Whether you're machining delicate components that require a high level of precision or working with materials that benefit from slower speeds, this tool allows you to easily apply the correct feed rate adjustments, ensuring your machine operates optimally for each specific task.


## Installation

1. Download the latest version of the **Feed Rate Adjuster** application from the [releases page](https://github.com/Booth-Ashley/Feed-Rate-Adjuster/releases).
2. Run the executable.

Alternatively, if you want to build the application from source:
1. Clone this repository.
2. Open the solution in **Visual Studio 2022**.
3. Build the solution using **Ctrl + Shift + B**.
4. Run the application using **F5**.

## Usage

1. **Launch the Application**: Open the **Feed Rate Adjuster** executable.
2. **Select a G-code File**: Click on the **Browse...** button and choose the G-code file (it should have the extension `.gcode`, `.tap`, or `.nc`).
3. **Enter the New Feed Rate**: In the **Enter New Feed Rate** field, input the desired feed rate between 1 and 10,000.
4. **Adjust the Feed Rate**: Click the **Run** button to apply the new feed rate to all `G2` and `G3` lines in the selected G-code file.
5. **Save the Adjusted File**: After the adjustment, you will be prompted to save the new G-code file.

## Example

Let's say you have a G-code file that looks like this over 1000's of lines:
```
G1 X-914.033 Y4.332 F2500.0
G3 X-909.642 Y1.819 I3.816 J1.574 F2500.0
G1 X-876.350 Y6.508 F2500.0
G2 X-874.837 Y6.046 I0.261 J-1.854 F2500.0
G1 X-869.154 Y0.931 F2500.0
G3 X-865.817 Y-0.088 I2.761 J3.069 F2500.0
G1 X-821.257 Y6.188 F2500.0
G3 X-817.879 Y11.463 I-0.576 J4.088 F2500.0
G1 X-824.319 Y32.905 F2500.0
G1 X-820.733 Y33.982 F2500.0
G1 X-817.577 Y23.475 F2500.0
G1 X-723.523 Y36.722 F2500.0
G1 X-723.001 Y33.014 F2500.0
G1 X-816.486 Y19.848 F2500.0
G1 X-811.804 Y4.332 F2500.0
G3 X-807.413 Y1.819 I3.816 J1.574 F2500.0
```

If you enter a feed rate of **500**, the modified G-code will be:
```
G1 X-914.033 Y4.332 F2500.0
G3 X-909.642 Y1.819 I3.816 J1.574 F500.0
G1 X-876.350 Y6.508 F2500.0
G2 X-874.837 Y6.046 I0.261 J-1.854 F500.0
G1 X-869.154 Y0.931 F2500.0
G3 X-865.817 Y-0.088 I2.761 J3.069 F500.0
G1 X-821.257 Y6.188 F2500.0
G3 X-817.879 Y11.463 I-0.576 J4.088 F500.0
G1 X-824.319 Y32.905 F2500.0
G1 X-820.733 Y33.982 F2500.0
G1 X-817.577 Y23.475 F2500.0
G1 X-723.523 Y36.722 F2500.0
G1 X-723.001 Y33.014 F2500.0
G1 X-816.486 Y19.848 F2500.0
G1 X-811.804 Y4.332 F2500.0
G3 X-807.413 Y1.819 I3.816 J1.574 F500.0
```

## Requirements

- **.NET Framework 4.7.2** or higher (included in the application build).
- A Windows operating system (Windows 7 or newer recommended).

## License

This project is licensed under the GNU General Public License v3.0 - see the [LICENSE](LICENSE) file for details.

## Contact

- **Author**: Ashley Booth
- **Email**: ashley@ashley-booth.com

