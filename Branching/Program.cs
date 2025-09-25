# Introductory message
print("Welcome to Package Express. Please follow the instructions below carefully.")

# Ask for weight of the package
package_weight = float(input("Enter the package weight (in lbs): "))

# Check if weight is within allowed limit
if package_weight > 50:
    print("Sorry, the package is too heavy for shipping with Package Express.")
    print("Have a great day!")
else:
    # Get package dimensions from user
    package_width = float(input("Enter the package width (in inches): "))
    package_height = float(input("Enter the package height (in inches): "))
    package_length = float(input("Enter the package length (in inches): "))

    # Calculate the total size
    total_size = package_width + package_height + package_length

    # Validate dimensions
    if total_size > 50:
        print("Sorry, the package is too large to be shipped via Package Express.")
    else:
        # Calculate shipping cost
        volume = package_width * package_height * package_length
        shipping_cost = (volume * package_weight) / 100

        # Display the estimated cost
        print(f"Estimated shipping cost: ${shipping_cost:.2f}")
        print("Thanks for using Package Express!")
