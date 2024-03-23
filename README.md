# apbd17-03
## *Application for managing container loading*
Written in C#
###### The system handle the loading of containers onto a container ship - a vessel equipped with special guides allowing for the transport of containers. Containers can be of different types depending on the cargo.
### *Features of containers:*

#### *For whole containers:*
###### Mass of the cargo in kilograms
###### Height in centimeters
###### Tare weight in kilograms 
###### Depth in centimeters
###### Serial number
###### The format of the number is KON-C-1
###### The first part of the number is always "KON"
###### The second part represents the type of container
###### The third part is a number. Numbers are unique. There is no possibility of two containers having the same number.
###### The maximum payload of a given container in kilograms


---


#### *All containers allow:*
###### Emptying the cargo
###### Loading the container with a given mass of cargo
###### If the mass of the cargo is greater than the capacity of a given container, we is thrown an OverfillException error


---


#### *Liquid Container:*
##### Liquid containers allow for the transportation of hazardous cargo and ordinary cargo. These types of containers are implemented the IHazardNotifier interface This interface allows for sending a text notification during the occurrence of a hazardous situation along with information about the container number. At the moment of initiating the loading method for goods into the container, there is : 
###### That If the container stores hazardous cargo - it can only be filled to 50% of its capacity. Otherwise, it can be filled up to 90% of its capacity
###### If we violate any of the described rules - we should report the attempt to perform a dangerous operation.


---


#### *Gas containers:*
###### Containers storing gas carry additional information about the pressure, in atmospheres.
###### When emptying a gas container - we leave 5% of its cargo inside the container.
###### Implement with IHazardNotifier interface. The method allow for informing about the occurrence of a hazardous event along with the serial number of the container. If the mass of the cargo exceeds the allowable payload thats return an error.


---


#### *Refrigerated container:*
##### A refrigerated container contains information about:
###### The type of product that can be stored in the container.
###### The temperature maintained in the container.
###### The container can only store products of the same type.
###### The temperature of the container cannot be lower than the temperature required by a given type of product.


---


#### *Container Ship:*
##### *Paramets:*
###### All the containers that the ship transports.
###### The maximum speed the container ship can develop in knots.
###### The maximum number of containers that can be transported.
###### The maximum weight of all containers that can be transported by the ship in tons.
##### *Operations:*
###### Create a container of a given type Load cargo into a given container Load a container onto a ship.
###### Load a list of containers onto a ship.
###### Remove a container from the ship.
###### Unload a container.
###### Replace a container on the ship with a given number with another container.
###### The possibility of transferring a container between two ships.
###### Print information about a given container.
###### Print information about a given ship and its cargo.
