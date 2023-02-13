**Applied Prototyping Skills - 3D Design Challenge**

**Scenario** 

Fachhochschule Salzburg wants to develop a new concept for their info screens, visitor guiding system and access authorization system. Your job is to prototype one scenario for simulating and planning the positioning of general information and info screens. Your prototype should be a  first step towards a sandbox environment for people working on the related conceptualization and room planning. Everything should be developed in a way that it is re-useable and adjustable, so that also non-unity experts could work on it without touching the scripts. Further, a new room is still in the making, i.e., the HCI Lab. This  room  can  be  envisioned  by  you  and  should  later  act  as  a  prototyping  lab  and research facility. Take the pictures below as a starting point...

**Tasks** 

**MAIN ENTRANCE HALL** 

- set up a new unity project and create a scene named "MAIN\_ENTRANCE\_HALL".
- prototype  the  FHS  entrance  hall  (it  can  be  simplified;  not  everything  needs  to  be included; try using the unity primitives; use the pictures above as inspiration; ground floor is enough)
- add lights to the scene (general lighting for the room + some spotlights highlighting certain areas)
- infoscreen Prefab
  - create an  "infoscreen" prefab  made out of unity primitives and position some of these "info screens" in the entrance hall (suggested position on the pictures below).
  - these screens should continuously change their color every 10 seconds

- add sound to the scene
  - add a background sound for the entrance hall (whatever you like)
  - some other spatial sound in the entrance hall that should decrease in volume when the character leaves the entrance hall area and comes closer to other areas
- character prefab
  - create a  character prefab: implement a  first person camera + character movement (i.e., movement via keyboard input, vertical and horizontal head rotation via mouse)
  - when the character initially enters the entrance hall, the head of the character should automatically rotate to one of the info screens.
- create  a  prefab  called  HCI\_Infoscreen  and  position  it  in  the  entrance  hall  (see approximate position on picture below)

**ZONES AND OTHER FUNCTIONALITY** 

- as soon as the character gets close enough to the HCI info screen, a range of small color indicators in the floor should change their color and guide the way to the HCI lab (see picture below).
- ZoneTimeAnalysis: create and add another type of trigger that monitors how much time the character was spending "inside this trigger". Output these values to the console as soon as the character exits an area. position three of them around the entrance hall
- position three zones around the entrance hall (e.g., Area A, Area B, Area C).

**HCI LAB ROOM** 

- create another scene named HCI\_LAB\_ROOM
- this new room should have a different background sound
- in your scene  MAIN\_ENTRANCE\_HALL load the new scene  HCI\_LAB\_ROOM as soon as the character moves close to the door of the other room (no access if the panel hasn't been visited before).
- add  at  least  three  3D  models  (from  external  sources)  to  that  scene.  They  should represent lab equipment and interaction technologies in that room (e.g., a robot arm, 3d printer,...).
- create a new prefab called  PROTOTYPE\_X (its up to you to decide on its look; use primitives or an existing model).
- one instance of this prefab should be positioned on a small podium slowly rotating in a spotlight (start that rotation as soon as the character enters the HCI LAB room).
- add another empty podium to the room. when the character comes close enough to the second podium, instantiate another instance of PROTOTYPE\_X on this podium.
- character  tries  to  interact:  when  the  user  presses  "E"  the  second  instance  of PROTOTYPE\_X  should be thrown off the podium and be destroyed.
- play a one-shot sound when the prefabs gets destroyed.

