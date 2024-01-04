
//make sure to refrence these. search "refrences" all of these should be in gods of gravity assembly
using ExitGames.Client.Photon;
using HarmonyLib;
using MelonLoader;
using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;



namespace GodsOfGravityMod
{ 
    public class mymodclass : MelonMod
    { 
        //make your mod here
        

        

       
        public override void OnInitializeMelon()
        { 
            //This Runs Once At the start of Melonloader, use this function to initilize anything

        }


        public override void OnFixedUpdate()
        {
            //this runs every frame no matter what


            if (NetworkManager.instance.isOnlineRoomOwner)
            {
                //runs if you are room owner
                LoggerInstance.Msg("Room Owner!");

            }
            if (RoomInfo.IsRoomInviteOnly() == true)
            {
                //runs if you are in invite only (please use this for gamechanging mods)
                LoggerInstance.Msg("Invite Only!");
            }
            if (RoomInfo.isInOnlineRoom == true)
            {
                //runs if you are in a room
                LoggerInstance.Msg("In Room!");

            }

        }
    }



}


              
            
               
                
            
                

            
           











