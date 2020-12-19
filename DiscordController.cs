using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordController : MonoBehaviour
{

    public Discord.Discord discord;

    public string details;
    public string state;
    public string img;
    public bool hasRoundCount = false;
    public bool newest = false;
    public time time;
    public ActivityManager activityManager;
    public Activity activity;
    private int rounds;
    public System.Int64 Time1;
    // Start is called before the first frame update
    void Start()
    {
        Time1 = (System.Int64)(System.DateTime.UtcNow.Subtract(new System.DateTime(1970, 1, 1))).TotalSeconds - (long)Time.time;


        if (newest == true)
        {
            discord = new Discord.Discord(789192548215947266, (System.UInt64)Discord.CreateFlags.NoRequireDiscord);
            activityManager = discord.GetActivityManager();
            if (hasRoundCount == true)
            {
                activity = new Discord.Activity
                {
                    Details = details,
                    State = state + time.round.ToString(),
                    Assets =
                {
                    LargeImage = img
                },
                    Timestamps =
                        {
                            Start = Time1
                        }

                };
            }
            else
            {
                activity = new Discord.Activity
                {
                    Details = details,
                    State = state,
                    Assets =
            {
                LargeImage = img
            },
                    Timestamps =
                {
                    Start = Time1
                }

                };
            }
            activityManager.UpdateActivity(activity, (res) =>
            {
                if (res == Discord.Result.Ok)
                    Debug.Log("set");
                else
                    Debug.LogError("RPC NOT WORKING");
            });

            rounds = time.round;
        }
        else
        {
            if (hasRoundCount == true)
            {
                activity = new Discord.Activity
                {
                    Details = details,
                    State = state + time.round.ToString(),
                    Assets =
                {
                    LargeImage = img
                },
                    Timestamps =
                {
                    Start = Time1
                }

                };
            }
            else
            {
                activity = new Discord.Activity
                {
                    Details = details,
                    State = state,
                    Assets =
            {
                LargeImage = img
            },
                    Timestamps =
                {
                    Start = Time1
                }

                };
            }
            activityManager.UpdateActivity(activity, (res) =>
            {
                if (res == Discord.Result.Ok)
                    Debug.Log("set");
                else
                    Debug.LogError("RPC NOT WORKING");
            });

            rounds = time.round;
        }
    }

    // Update is called once per frame
    void Update()
    {
        discord.RunCallbacks();

        if (rounds != time.round && hasRoundCount == true)
        {
            activity = new Discord.Activity
            {
                Details = details,
                State = state + time.round.ToString(),
                Assets =
                    {
                        LargeImage = "zombie"
                    },
                Timestamps =
                {
                    Start = Time1
                }

            };
            activityManager.UpdateActivity(activity, (res) =>
            {
                if (res == Discord.Result.Ok)
                    Debug.Log("set");
                else
                    Debug.LogError("RPC NOT WORKING");
            });

            rounds = time.round;
        }
    }
}
